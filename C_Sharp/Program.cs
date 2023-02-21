namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Priting();
            // comments(); nothing will appear
            DataTypesAndVars();
        }

        static void Priting()
        {
            // Anything + line = *Pressing enter*
            Console.Write("Yoo, Mr.White .. ");
            Console.WriteLine("Yoo, Mr.Blue");
            Console.Write("Yoo, Mr.Green");
        }

        static void comments()
        {
            // well thats a comment lol
            /* 
             bla bla bla bla bla bla
             */
        }

        static void DataTypesAndVars()
        {
            string str  = "Damn bro";    // 2 bytes pre char 
            int inte = 46;               // 4 bytes
            double dbl = 4.5;            // 8 bytes
            char chr = 'a';              // 2 bytes
            bool bol = true;             // 1 bit
            const int cnst = 5;          // 4 bytes (can't be changed)

            Console.WriteLine(str + "  " + inte + "  " + dbl + "  " + chr + "  " + bol + "  " + cnst);
            Console.WriteLine(inte + dbl + cnst);
        }

        












    }
}