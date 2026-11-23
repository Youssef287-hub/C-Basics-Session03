namespace Assignment__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // 1- Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".      
            ///int pages = 464;
            ///if(pages > 300)
            ///{
            ///    Console.WriteLine("Long Book");
            ///}
            ///else
            ///{
            ///    Console.WriteLine("Short Book");
            ///}
            #endregion

            #region Question 2
            //2- Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.
            ///int pages = 464;
            ///bool isAvailable = true;
            ///if(pages> 300 && isAvailable)
            ///{
            ///    Console.WriteLine("You can borrow this book");
            ///}
            #endregion

            #region Question 3
            //3- Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            ///string title = "Refactoring";
            ///switch(title)
            ///{
            ///    case "Clean Code":
            ///        Console.WriteLine("Great choice!");
            ///        break;
            ///    case "Refactoring":
            ///        Console.WriteLine("Nice pick!");
            ///        break;
            ///    default:
            ///        Console.WriteLine("Never heard of it");
            ///        break;
            ///}


            #endregion

            #region Question 4
            //4- Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).
            int pages = 464;

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            #endregion
        }
    }
}
