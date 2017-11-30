using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice2
{
    class robot
    {//base price 50,000 with legs, 10,000 per arm, 20,000 if wheels, 50,000 if hover

        //data members
        private int arms;
        private string transmode; //legs, wheels, hover
        private int quantity;

        //constructors

        public robot()
        {
            arms = 2;
            transmode = "Legs";
            quantity = 1;

        }

        public robot(int arms, string transmode, int quantity)
        {
            //protect numeric values
            if (arms > 0)
            { this.arms = arms; }
            else
            { Console.WriteLine("Error."); }

            this.transmode = transmode;

            if (quantity > 0)
            { this.quantity = quantity; }
            else
            { Console.WriteLine("Error."); }

        }

        //Properties get set

        public int Arms
        {
            get { return arms; }

            set
            {
                if (value > 0)
                { arms = value; }
            }
        }

        public string Transmode
        {
            get { return transmode; }

            set { transmode = value; }


        }

        public int Quantity
        {
            get { return quantity; }

            set
            {
                if (value > 0)
                { quantity = value; }
            }

        }

            //Methods

        public double TotalCost()
        {
            double totalCost = (quantity * 50000);

            return totalCost;
        }

       public void PrintInfo()
        {
            Console.WriteLine("You have ordered {0} robot(s) with {1} arms in {2} mode.", quantity, arms, transmode);
        }

        }
    }
