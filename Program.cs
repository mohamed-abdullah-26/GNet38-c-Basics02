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
            string title = "clean code";
            string UperTitle = title.ToUpper();
            Console.WriteLine($"UperTitle : {UperTitle}");
            Console.WriteLine($"title :{title} ");
            #endregion
        }
    }
}
