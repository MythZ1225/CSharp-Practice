using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive_Management
{
    public class Queen : Bee
    {
        private WorkerBee[] workers;
        private int shiftNum;

        public Queen(WorkerBee[] workers) :base(275)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job,numOfShifts))
                {
                    return true;
                }               
            }
            return false;
        }
                
        public string WorkTheNextShift()
        {
            double totalComption = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                totalComption += workers[i].GetHoneyConsuption();//工蜂消耗
                totalComption += GetHoneyConsuption();  //蜂王消耗
            }

            shiftNum++;
            string report = "工班報告 #" + shiftNum + "\r\n";
            report += "總蜂蜜消耗 :" + totalComption;
                        
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                {
                    report += "工蜂 #" + (i + 1) + " 完成工作 \r\n";
                }

                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += "工蜂 #" + (i + 1) +"可以做"+ workers[i].JobsCanIDo + " 但沒有工作 \r\n";
                }
                else if (workers[i].ShiftLeft >0)
                {
                    report += "工蜂 #" + (i + 1) + " 執行工作 '" + workers[i].CurrentJob+"' 還有 " + workers[i].ShiftLeft + " 班次 \r\n";
                }
                else
                {
                    report += "工蜂 #" + (i + 1) + " 將於這個班次後完成 '" + workers[i].CurrentJob + "' \r\n";
                }
            }
            return report;
        }
        public override double GetHoneyConsuption()
        {
            double HoneyConsuption = 0;
            double largestWorkerComption = 0;
            int workersDoingJobs = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsuption() > largestWorkerComption)
                {
                    largestWorkerComption = workers[i].GetHoneyConsuption();
                }
                if (workers[i].ShiftLeft >0)
                {
                    workersDoingJobs++;
                }
            }
            HoneyConsuption += largestWorkerComption;
            if (workersDoingJobs >= 3)
            {
                HoneyConsuption += 30; //如果大於3隻在工作，母后需要花30單位
            }
            else
            {
                HoneyConsuption += 20;//OR 母后只要花20單位
            }


            return base.GetHoneyConsuption();
        }
    }
}
