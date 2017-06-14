using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _377ShoeCloset_List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> 鞋櫃 = new List<Shoe>();

            鞋櫃.Add(new Shoe() { Style = Style.B牛皮, Color = Color.Br棕 });
            鞋櫃.Add(new Shoe() { Style = Style.W合成皮, Color = Color.W白 });
            鞋櫃.Add(new Shoe() { Style = Style.C小牛皮, Color = Color.B黑 });
            鞋櫃.Add(new Shoe() { Style = Style.S蛇紋, Color = Color.G綠 });
            鞋櫃.Add(new Shoe() { Style = Style.T樹脂, Color = Color.R紅 });
            鞋櫃.Add(new Shoe() { Style = Style.P塑膠, Color = Color.Y黃 });

            int 鞋子數 = 鞋櫃.Count();
            PrintShoes(鞋櫃);
            
                        
            鞋櫃.RemoveAt(4); // 移除 List的第五雙鞋
            PrintShoes(鞋櫃);

            foreach (Shoe shoe in 鞋櫃) //把所有鞋都變BY
            {
                shoe.Style = Style.B牛皮;
                shoe.Color = Color.Y黃;
            }
            PrintShoes(鞋櫃);


            Shoe TriShoe = 鞋櫃[3];   //先留個位置給他存放
            Shoe SecShoe = 鞋櫃[2];   //先留個位置給他存放 方便之後叫出來
            鞋櫃.Clear(); // 清空所有鞋
            PrintShoes(鞋櫃);

            鞋櫃.Add(TriShoe); //上面的TriShoe發揮作用了
            PrintShoes(鞋櫃);

            if (鞋櫃.Contains(SecShoe))
            {
                Console.WriteLine("怎麼可能"); //沒有Add(SecShoe) 所以這句其實不會執行
            }



        }

        public static void PrintShoes(List<Shoe> shoes)
        {
            foreach (Shoe shoe in shoes)
            {
                Console.WriteLine(shoe.Color.ToString() + shoe.Style.ToString());
            }
            Console.WriteLine("沒鞋了");
            Console.ReadKey();
            Console.WriteLine("\n");
        }


    } 

    class Shoe
    {
        public Style Style;
        public Color Color;
    }

    enum Style
        {
            S蛇紋,
            C小牛皮,
            B牛皮,
            T樹脂,
            W合成皮,
            P塑膠,
        }
    enum Color
    {
        B黑,
        W白,
        R紅,
        Y黃,
        Br棕,
        G綠,
    }
}
