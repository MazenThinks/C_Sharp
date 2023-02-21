namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Priting();
            // comments(); nothing will appear
            // DataTypesAndVars();
            TypeCasting();
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

        static void TypeCasting()
        {
            // Implicit Casting
            int myInt = 5;
            double myDouble;
            myDouble= myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // Explicit Casting
            double mydbl = 5.5;
            int myint = (int)myDouble;

            Console.WriteLine(myint); // converting double to int

            Console.WriteLine(Convert.ToInt32(myDouble)); // converting double to int in another way
        }














    }
}