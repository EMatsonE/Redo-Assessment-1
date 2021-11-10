using System;

namespace Redo_Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool redo = true;
            while (redo == true)
            {
                Console.WriteLine("1.Burger");
                Console.WriteLine("2.Soda");
                Console.WriteLine("3.Exit");
                redo = GoAgain();
            }
        }
        public static bool GoAgain()
        {
            double subTotal = SubTotal();
            double total = Total();
            double addBurger = AddBurger();
            string userInput = Console.ReadLine().Trim().ToLower();
            if (userInput == "1")
            {
                AddBurger();
                return true;
            }
            if (userInput == "2")
            {
                AddSoda();
                return true;
            }
            if (userInput == "3")
            {
                Console.WriteLine($"Subtotal: {subTotal}");//needs to add things together and print to console
                Console.WriteLine($"Total: {total}");
                return false;
            }
            else
            {
                Console.WriteLine("You need to type 1, 2, or 3.");
                return true;
            }

        }
        public static double Total()
        {
            double subTotal = SubTotal();
            double total = subTotal * 1.07;
            return total;
        }
        public static double SubTotal()
        {
            double subTotal = AddBurger() + AddSoda();
            return subTotal;
        }
        public static double AddBurger()
        {
            double start = 0;
            double burger = 2.50;
            double subTotal = start + burger;
            return subTotal;
        }
        public static double AddSoda()
        {
            double start = 0;
            double soda = 1.25;
            double subTotal = start + soda;
            return subTotal;
        }
        public static void Rubric()
        {
            //1. 1pt - In your Main, write a loop that repeatedly presents the user with a menu of the---
            //following numbered options.The output must be formatted with each option on its---
            //own line exactly like this.---
            //1.Burger---
            //2.Soda---
            //3.Exit---

            //2. 1pt - Continue looping until the user enters 3. (3 for Exit)---

            //3.Each time through the loop…
            //a.If the selection is 1, add a burger to the order.
            //b.If the selection is 2, add a soda to the order.
            //c.If the selection is 3, the loop ends.---
            //d. 1pt - If any other number is entered, print "Sorry I didn’t understand, let’s---
            //try again.". The loop then continues to the next run---

            //4.After the loop finishes, print the subtotal of the user’s order. It MUST be printed on a
            //line along with the word "Subtotal".Each burger costs $2.50.Each soda costs $1.25.
            //(Note: the number formatting is not important as long as the value is correct.For
            //example, an order of 3 burgers can simply print 7.5 for the subtotal.) It is possible to get
            //partial credit based on the following cases, up to 3pts:
            //a. 1pt - The subtotal is calculated correctly when order contains only burgers.
            //b. 1pt - The subtotal is calculated correctly when order contains only sodas.
            //c. 1pt - The subtotal is calculated correctly for an order of several burgers and
            //sodas.

            //5. 1pt - Next add 7% tax onto the subtotal and print the total. It MUST be printed on a line---
            //along with the word "Total".---

            //6. 2pt - Next print a line with one asterisk for each burger purchased.It MUST be printed
            //on a line along with the word "Burger". For example, if 4 burgers were added to the
            //order:
            //Burgers: ****

            //7. 1pt - Next print a line with one asterisk for each soda purchased.It MUST be printed on
            //a line along with the word "Soda". For example, if 2 sodas were added to the order:
            //Sodas: **
        }
    
    }
}
