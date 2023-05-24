using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge_5_23
{
    public class Solution
    {
        public int SecondMaxValue(int[] input)
        {
            /*
             * If I am allowed to use functions provided by the library. but if not then I would just retrieve the max value while also tracking the last value to be tracked.
             * Array.Sort(input);
             * return input[1];
             */
            int holder;
            for(int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[j] > input[i])
                    {
                        holder = input[i];
                        input[i] = input[j];
                        input[j] = holder;
                    }
                }
            }
            return input[1];
        }

        public int AlphnumericValue(string input)
        {
            /*
             * So what I could do is basically have a foreach loop in where we check to see each char value is in the range of the ASCII code in that it would be considered an actual number and if so convert it to int and add it to the sum value and return the sum
             */
            int sum = 0;
            foreach(char value in input)
            {
                //Char.IsDigit, if I can't use the function given to us in the library then instead I would get the ASCII value and see if it is within range of the ASCII value of 0-9
                if ((int)value >= 48 && (int)value <= 57)
                {
                    sum += int.Parse(value.ToString());
                }
            }

            return sum;
        }
    }
}
