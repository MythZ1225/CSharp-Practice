using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _467_Excuse_UsingDispose
{
    public partial class Form1 : Form
    {
        private Excuse CurrentExcuse = new Excuse();
        private string selectFolder = "";
        private bool formChange = false;
        Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
            CurrentExcuse.LastUsed = LastUsedTime.Value;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.ExcuseBox.Text = CurrentExcuse.Description;
                this.ResultBox.Text = CurrentExcuse.Result;
                this.LastUsedTime.Value = CurrentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(CurrentExcuse.ExcusePath))
                {
                    DateBox.Text = File.GetLastWriteTime(CurrentExcuse.ExcusePath).ToString();
                }
                else
                {
                    this.Text = "藉口管理員";
                }
            }
            else
            {
                this.formChange = changed;
            }
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectFolder = folderBrowserDialog1.SelectedPath;
                SaveBtn.Enabled = true;
                OpenBtn.Enabled = true;
                RandomBtn.Enabled = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ExcuseBox.Text)||String.IsNullOrEmpty(ResultBox.Text))
            {
                MessageBox.Show("要填藉口跟結果!","無法存檔",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectFolder;
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt | All File(*.*)|*.*";
            saveFileDialog1.FileName = ExcuseBox.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK )
            {
                CurrentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (CheckChange())
            {
                openFileDialog1.InitialDirectory = selectFolder;
                openFileDialog1.Filter = "Text File (*.txt)|*.txt | All File(*.*)|*.*";
                openFileDialog1.FileName = ExcuseBox.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CurrentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                    MessageBox.Show("藉口載入！");
                }
            }
            
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            if (CheckChange())
            {
                CurrentExcuse = new Excuse(random, selectFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChange()
        {
            if (formChange)
            {
                DialogResult result = MessageBox.Show("目前資料尚未存檔，是否繼續？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void ExcuseBox_TextChanged(object sender, EventArgs e)
        {
            CurrentExcuse.Description = ExcuseBox.Text;
            UpdateForm(true);
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            CurrentExcuse.Result = ResultBox.Text;
            UpdateForm(true);
        }

        private void LastUsedTime_ValueChanged(object sender, EventArgs e)
        {
            CurrentExcuse.LastUsed = LastUsedTime.Value;
            UpdateForm(true);
        }
    }
}
