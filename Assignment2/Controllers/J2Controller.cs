using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /*
         This method takes two parameters in integers where m is the number of sides of Dice 1 and n the number
        of sides of Dice 2. It returns the number of ways two dice can return the sum of 10.
        example: if m = 15, n=20, then there are 11 ways to get sum of 10
         */
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int counter = 0;

            /* using nested loops to pair each value of dice 1 to values of dice 2 and an if statement to check if the pair returns
             value 10 */
            for (int i=0; i<=m; i++) 
            { 
                for (int j=0; j<=n; j++) 
                {
                    if (i + j == 10)
                    {
                        counter++;
                    }
                }
            }
            return "There are " + counter.ToString() + " total ways to get the sum 10 ";
        }
    }
}
