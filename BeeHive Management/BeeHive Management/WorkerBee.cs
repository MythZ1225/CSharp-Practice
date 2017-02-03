using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive_Management
{
    public class WorkerBee :Bee
    {
        public WorkerBee(string[] jobsCanIDo, int weight) : base(weight)
        {
            this.jobsCanIDo = jobsCanIDo;
        }
        
        public override int ShiftLeft
        {
            get
            {
                return shiftToWork - shiftWorked;
            }
        }

        private string currentJob = "";
        public string CurrentJob
        {
            get {
                return currentJob;
            }
        }

        private int shiftToWork;
        private int shiftWorked;
        private string[] jobsCanIDo;

        public string[] JobsCanIDo
        {
            get
            {
                return jobsCanIDo;
            }
        }

        public bool DoThisJob(string job, int numOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
                        
            for (int i = 0; i < jobsCanIDo.Length; i++)
                {
                    if (jobsCanIDo[i] ==job )
                    {
                        currentJob = job;
                        this.shiftToWork = numOfShifts;
                        shiftWorked = 0;
                        return true;
                    }                    
                }
            return false;
        }

        public bool  WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            else
            {
                shiftWorked++;

                if (shiftWorked > shiftToWork)
                {
                    shiftWorked = 0;
                    shiftToWork = 0;
                    currentJob = "";
                    return true;
                }
                else
                {
                    return false;
                }

            }


        }

    }
}
