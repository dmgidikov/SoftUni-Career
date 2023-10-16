using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Exeptions
{
    public class Exeptions
    {
        public static string InvalidTypeExeption =
            "Invalid type of dough";

        public static string DoughWeightExeption =
           "Weight cannot be zero or negative number";

        public static string ToppingInproperTypeExeption =
          "Cannot place {0} on top of your pizza.";

        public static string ToppingWeightExeption =
         "{0} weight should be in the range [1..50].";

        public static string PizzaNameExeption =
         "Pizza name should be between 1 and 15 symbols.";

        public static string PizzaTotalToppingsExeption =
       "Number of toppings should be in range [0..10].";
    }
}
