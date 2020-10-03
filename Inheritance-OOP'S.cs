using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    public abstract class cricket

    {
        protected int maxOvers;
        protected int targetScore;
        protected int currentOver;
        protected int currentScore;
        public int MaxOvers
        {

            get { return maxOvers; }
        }

        public int TargetScore
        {

            get
            {
                return targetScore;
            }

        }
        public int CurrentOver
        {
            get { return currentOver; }
            set { currentOver = value; }
        }
        public int CurrentScore
        {
            get { return currentScore; }
            set { currentScore = value; }
        }
        public cricket(int maxOver, int targetScore)
        {
            this.maxOvers = maxOver;
            this.targetScore = targetScore;

        }
        public abstract double CalculatecurrrentRunrate();

        public abstract double CalculateReqrunrate();
    }

    public class OneDaycricket : cricket
    {

        double currentRunrate, Reqrunrate;
        public OneDaycricket(int crtover, int crtscote, int target)
        {
            this.CurrentScore = crtscote;
            this.CurrentOver = crtover;
            this.targetScore = target;
            this.maxOvers = 50;

        }

        public override double CalculatecurrrentRunrate()
        {


            currentRunrate = currentScore / currentOver;
            return currentRunrate;

        }
        public override double CalculateReqrunrate()
        {
            int remainingruns = targetScore - currentScore;
            int remainingover = maxOvers - currentOver;
            Reqrunrate = remainingruns / remainingover;
            return Reqrunrate;

        }



    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cricket;


namespace Abstarct1
{

    class cricketTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the target runs");
            int targetruns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the current over");
            int currentover = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter current score");
            int currentscore = Convert.ToInt32(Console.ReadLine());
            OneDaycricket D = new OneDaycricket(currentover, currentscore, targetruns);

            double x = D.CalculatecurrrentRunrate();
            double y = D.CalculateReqrunrate();
            Console.WriteLine("current run rate{0} the required run rate is  {1}", x, y);
            Console.ReadKey();









        }
    }

}



