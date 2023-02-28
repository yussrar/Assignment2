using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        /*
        This method takes 4 parameters in integer for a burger, a drink, a side and a dessert respectively and 
        uses if statements to calculate the calories for each selection, returns the total calories in integer.
        example: if burger=2, drink=1, side=1, dessert=2, The total = 927
        */
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public int Menu(int burger, int drink, int side, int dessert)
        {
            //Burgers
            int Cheeseburger = 461;
            int Fishburger=431;
            int Veggieburger = 420;

            //drinks
            int Softdrink=130;
            int Orangedrink=160;
            int Milk=118;

            //sides
            int Fries = 100; ;
            int Bakedpotato=57;
            int Chefsalad=70;

            //desserts
            int Applepie = 167;
            int Sundae = 266;
            int Fruitcup = 75;

            int total = 0;

            //checking for burgers

            if (burger==1)
            {
                total = total + Cheeseburger;
            }
            else if(burger==2)
            {
                total = total + Fishburger;
            }
            else if (burger == 3)
            {
                total= total + Veggieburger;
            }

            else if(burger==4)
            {
                total = total + 0;
            }

            // checking for drinks

            if (drink == 1)
            {
                total = total + Softdrink;
            }
            else if (drink == 2)
            {
                total = total + Orangedrink;
            }
            else if (drink == 3)
            {
                total = total + Milk;
            }

            else if (drink == 4)
            {
                total = total + 0;
            }


            //checking for sides

            if (side == 1)
            {
                total = total + Fries;
            }
            else if (side == 2)
            {
                total = total + Bakedpotato;
            }
            else if (side == 3)
            {
                total = total + Chefsalad;
            }
            else if (side == 4)
            {
                total = total + 0;
            }

            //checking for dessert

            if (dessert == 1)
            {
                total = total + Applepie;
            }
            else if (dessert == 2)
            {
                total = total + Sundae;
            }
            else if (dessert == 3)
            {
                total = total + Fruitcup;
            }

            else if (dessert == 4)
            {
                total = total + 0;
            }

            //returning total
            return total;
        }
    }
}
