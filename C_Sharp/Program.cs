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
            string str  = "Damn bro";
            int inte = 46;
            double dbl = 4.5;
            char chr = 'a';
            bool bol = true;

            Console.Write(str + " " + inte + " " + dbl + " " + chr + " " + bol);
        }










    }
}