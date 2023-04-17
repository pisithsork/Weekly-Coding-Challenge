using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class Solutions
    {            /* Thought Process:
             *  What I can do is have a foreach/for loop, convert each letter to char and check if the value lies between 65 and 90 as these values will be only uppercase letters. If the edge cases includes special character than that is still fine. If this condition is true then take the index and add it to the result[]. After the foreach/for loop is done return the result.
             */
        public int[] IndexofCapitals(string input)
        {

            List<int> result = new List<int>();
            foreach(char c in input)
            {
                if (Char.IsUpper(c))
                {
                    result.Add(input.IndexOf(c));
                }
            }
            return result.ToArray();

        }
    }
}
