using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print 
            //both title and upperTitle to show that title did not change.
            //    string title = "clean code";
            //      string UperTitle = title.ToUpper();
            //       Console.WriteLine($"UperTitle : {UperTitle}");
            //     Console.WriteLine($"title :{title} ");
            #endregion
            #region Q2
            // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
            // check if they point to the same object in memory.
            string x = "Clean Code";
            string y = "Clean Code";
           bool aresame =object.ReferenceEquals(x, y);
            Console.WriteLine($"Are x and y the same object in memory? {aresame}");
            #endregion
        }
    }
}
