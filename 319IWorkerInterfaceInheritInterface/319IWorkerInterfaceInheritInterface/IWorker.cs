using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _319IWorkerInterfaceInheritInterface
{
    interface IWorker
    {
        string Job { get; }
        int ShiftsLeft { get; }
        void DoThisJob(string job, int shifts);
        void WorkOneShift();
    }

    interface IStingPatrol : IWorker
    {
        int AlterLevel { get;  }
        int StingerLength { get;  }
        bool LookForEnemy();
        int ShapenStinger(int Length);

    }

    class Robot
    {
        public void ConsumeGas() { }

    }

    class RobotBee : Robot,IWorker
    {
        public string Job { get; private set; }
        private int shiftToWork, shiftsLeft;
        public int ShiftsLeft { get { return shiftToWork - shiftsLeft; } }
        public void DoThisJob(string job, int shifts) { }
        public void WorkOneShift() { }

    }
}
