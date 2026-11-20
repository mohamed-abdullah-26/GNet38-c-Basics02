using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print 
            //both title and upperTitle to show that title did not change.
               string title = "clean code";
                 string UperTitle = title.ToUpper();
                  Console.WriteLine($"UperTitle : {UperTitle}");
                Console.WriteLine($"title :{title} ");
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q2
            // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            //  check if they point to the same object in memory.
            string x = "Clean Code";
                 string y = "Clean Code";
              bool aresame =object.ReferenceEquals(x, y);
             Console.WriteLine($"Are x and y the same object in memory? {aresame}");
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
            //object.Print the final result.

                        StringBuilder name= new StringBuilder();
            name.Append("Book List");
            name.Append(" - Updated");
            name.ToString();
            Console.WriteLine(name);

            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q4
            //  Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            StringBuilder name1 = new StringBuilder();
            name1.Append("Book List");
            name1.Append(" - Updated");
            name1.Replace("Book List", "Library");
            Console.WriteLine(name1);

            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, 
       // Pages: 464" using the + operator
            string title1 = "Clean Code";
            int pages = 464;
            Console.WriteLine(  title1 + pages  );

            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q6
            //Build the same sentence as above, but using string interpolation ($"...")
            string title2 = "Clean Code";
            int pages1 = 464;
            Console.WriteLine($"Title: {title2}, Pages: {pages1}");
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q7
            //Build the same sentence again, but using string.Format()
            string title6 = "Clean Code"; 
            int pages6 = 464; 

string Format = string.Format("title6: {0}, Pages6: {1}", title6, pages6); 
Console.WriteLine(Format);
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 
           // 300, otherwise prints "Short Book"
            
            int pages3 = 464;
           if(pages3 >300)
           {
               Console.WriteLine("long book");
          }
         
            else
            {
                Console.WriteLine("short book");
            }
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is 
           // greater than 300 and isAvailable is true.Use the && operator

            int pages2 = 464;
            bool isAvailable = true;
            if(pages2 > 300 && isAvailable)
                Console.WriteLine("You can borrow this book");

            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q10
            // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is 
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else

            string title3 = "Refactoring";
            switch(title3)
            {
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
             
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q11
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a 
            //variable sizeLabel(same rule as question 8: long if pages > 300)
             
                int pages4 = 464;

            string sizeLabel = (pages4> 300) ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q12
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop 
           // to print each book with its position number, like 1.Clean Code

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i=0;i<books.Length;i++)
            {
                Console.WriteLine($"{i+1}. {books[i]}");
            }
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q13
            //Using the same books array, use a while loop to print every book title

            string[] books2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int index = 0;
            while (index < books2.Length)
            {
                Console.WriteLine($"{index + 1}. {books2[index]}");
                index++;
            }
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q14
            //Write a do-while loop that prints "Checking book..." exactly 3 times

            int n = 0;
            do
            {
                Console.WriteLine("Checking book...");
                n++;
            } while (n < 3);

            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q15
            //Using the same books array, use a foreach loop to print every book title

            string[] books3 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books3) {

                Console.WriteLine(book);
            }
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q16
            //Using the same books array, loop through it and print each title, but stop completely (break) once 
           // you reach "Refactoring"

            string[]book4 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int b = 2;
            for (int i = 0; i < book4.Length; i++)
            {
                if (i == b)
                {
                    Console.WriteLine($" stop completely {book4[i]}");
                    break;
                }
                Console.WriteLine(book4[i]);
            }
            #endregion
            Console.WriteLine("---------------------------------------------");
            #region Q17
            //Using the same books array, print every title except "The Pragmatic Programmer" (skip it with 
           // continue, don't stop the loop)

            string[] book5 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };   
            int z = 1;
            for(int i = 0; i < book5.Length; i++)
            {
                if (i == z)
                {
                    Console.WriteLine($" skipping {book5[i]}");
                    continue;
                }
                Console.WriteLine(book5[i]);
            }
            #endregion
            Console.WriteLine("---------------------------------------------");
           

        }
    }
}
