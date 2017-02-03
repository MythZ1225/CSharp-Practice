using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive_Management
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            InitializeComponent();
            WorkerBee[] workers = new WorkerBee[4];
            workers[0] = new WorkerBee(new string[] { "採花粉", "做花蜜" },175);
            workers[1] = new WorkerBee(new string[] { "照顧蛋", "托嬰" },114);
            workers[2] = new WorkerBee(new string[] { "清理窩", "巡邏" },149);
            workers[3] = new WorkerBee(new string[] { "採花粉", "做花蜜", "照顧蛋", "托嬰", "清理窩", "巡邏" },155);
            queen = new Queen(workers);
        }

        private void AssignJobBtn_Click_1(object sender, EventArgs e)
        {
            if (queen.AssignWork(workBeeJob.Text, (int)shift.Value) == false)
            {
                MessageBox.Show("沒工蜂可以做這工作 :" + workBeeJob.Text + shift.Value+"班");
            }
            else
            {
                MessageBox.Show("工作 :" + workBeeJob.Text + "會被執行，" + shift.Value + "班");
            }
        }

        private void NextShiftBtn_Click(object sender, EventArgs e)
        {
            reportCum.Text = queen.WorkTheNextShift();
        }
    }
}
