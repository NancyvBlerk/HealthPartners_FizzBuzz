using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartners_FizzBuzz
{
    internal class Functionality
    {
        public StringBuilder MyOwn()
        {
            StringBuilder sb = new();

            bool t3, y5;

            for (int i = 1; i < 101; i++)
            {
                t3 = isDevisable3(i);
                y5 = isDevisable5(i);
                switch (t3, y5)
                {
                    case (true, true):
                        sb.AppendLine("FizzBuzz");
                        break;
                    case (false, false):
                        sb.AppendLine(i.ToString());
                        break;
                    case (true, false):
                        sb.AppendLine("Fizz");
                        break;
                    case (false, true):
                        sb.AppendLine("Buzz");
                        break;
                }
            }

            return sb;
        }

        private bool isDevisable5(int number)
        {
            if (number != 0 && number % 5 == 0)
            {
                return true;
            }
            else return false;
        }

        private bool isDevisable3(int number)
        {
            if (number != 0 && number % 3 == 0)
            {
                return true;
            }
            else return false;
        }


    }



}
