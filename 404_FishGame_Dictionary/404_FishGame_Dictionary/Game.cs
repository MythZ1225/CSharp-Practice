using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404_FishGame_Dictionary
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> OpponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in OpponentNames) //每個對手
            {
                players.Add(new Player(player, random, textBoxOnForm)); //加入戰局
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand(); //手牌順一下值
        }

        public void Deal()
        {
            stock.Shuffle(); //開始的時候要洗牌→ 去做一個Deck.shuffle()
            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                {
                    Card cardTOtake = stock.Deal(); //需要一個發牌的方法 Deck.Deal()

                    player.TakeCard(cardTOtake);    //需要一個方法 把發出來的手牌加到玩家手上→做一個player.TakeCard()
                }
            }

            //稍晚才加進來的  PullOutBooks(player);
            foreach (Player player in players)
            {
                PullOutBooks(player);
            }
        }

        public bool PlayOneRound(int selectedPlayerCard) //單回合流程
        {
            Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i ==0)
                {
                    players[0].AskForACard(players,0, stock, cardToAskFor); //玩家叫牌 → 去做一個 players.AskForCard()
                }
                else
                {
                    players[i].AskForACard(players, i, stock);  //AI叫牌
                }

                if (PullOutBooks(players[i]))                   //補牌程序
                {
                    textBoxOnForm.Text += players[i].Name
                                        + "新抽一手" + Environment.NewLine;

                    int card = 1;
                    while (card <= 5 && stock.Count > 0)    //當牌不滿5張
                    {
                        players[i].TakeCard(stock.Deal());  //補排到5張
                        card++;
                    }
                }

                players[0].SortHand(); //順一下牌

                if (stock.Count == 0)                       //牌堆沒牌時
                {
                    textBoxOnForm.Text = "牌堆沒排了" + Environment.NewLine;
                    return true;
                }
            }
            return false;
        }

        public bool PullOutBooks(Player player) //成套的牌抽掉了沒? 
        {
            IEnumerable<Values> bookPulled = player.PullOutBooK(); 
            foreach (Values value in bookPulled)
            {
                books.Add(value, player);
            }
            if (player.CardCount == 0 )
            {
                return true;    //抽掉了回傳true
            }
            else
            {
                return false;
            }
            
        }

        public string DescribeBooks() //記錄各玩家的成套分數
        {
            string whoHasWhichBooks = "";
            foreach (Values value in books.Keys)
            {
                whoHasWhichBooks += books[value].Name + "有成套的"
                    + Card.Plural(value)                // ?對 → 去寫Card.plural()
                    + Environment.NewLine;
            }
            return whoHasWhichBooks;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))      //當有多個第一名時
                    winners[name]++;   
                else
                    winners.Add(name, 1);           //依據玩家的名字為key, 加入Value值 1 作為名次
            }

            int mostBooks = 0;                      //最多套的數量
            foreach (string name in winners.Keys)   //取得Keylist 逐一檢查
            {
                if (winners[name]>mostBooks)        //讓贏家名字key的值 取代mostBooks的值
                {
                    mostBooks = winners[name];
                }
            }

            bool tie = false;                       //平手處理
            string winnerList = "";
            foreach (string name in winners.Keys)   //檢查每個winner.Keys
            {
                if (winners[name] == mostBooks)     //假使有name Key的 value 與 mostBook 相同 → 平手
                {
                    if (!String.IsNullOrEmpty(winnerList))   //同時假使  winnerList 已經有名字了
                    {
                        winnerList += " 與 ";                //名字後面加上 " 與 " 跟另一個名字
                        tie = true;
                    }
                    winnerList += name;
                }
            }

            winnerList += " 以 " + mostBooks + "套"; // 宣告成績
            if (tie)
            {
                return "的成績平手於" + winnerList;
            }
            else
            {
                return winnerList;
            }
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()  //描述玩家手牌
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + "有" + players[i].CardCount  ;
                if (players[i].CardCount ==1)
                {
                    description += "張牌." + Environment.NewLine;
                }
                else
                {
                    description += "張牌s." + Environment.NewLine;
                }
            }
            description += "牌堆剩" + stock.Count + "張牌";
            return description;
        }
    }
}
