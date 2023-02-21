namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Priting();
            // comments(); nothing will appear
            // DataTypesAndVars();
            // TypeCasting();
            // InputsFromUser();
            Operators();
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
            int myint = (int)mydbl;

            Console.WriteLine(myint); // converting double to int

            Console.WriteLine(Convert.ToInt32(mydbl)); // converting double to int in another way
        }

        static void InputsFromUser()
        {
            // sum of 2 inputs (lvl ez)
            //declaring vars
            int fn, sn;

            // first input
            Console.Write("Enter the first number : ");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // second input
            Console.Write("Enter the second number : ");
            sn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Output
            Console.WriteLine("The sum of these two numbers is : " + (fn + sn));
        }

        static void Operators()
        {
            double o1, o2;
            // first input
            Console.Write("Enter the first number : ");
            o1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // second input
            Console.Write("Enter the second number : ");
            o2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Output ( All Operators )
            Console.WriteLine("The Addition (+) of these two numbers is : " + (o1 + o2));  // Addition
            Console.WriteLine("The Substraction (-) of these two numbers is : " + (o1 - o2));  // Substraction
            Console.WriteLine("The Multiplication (*) of these two numbers is : " + (o1 * o2));  // Multiplication
            Console.WriteLine("The Division(/) of these two numbers is : " + (o1 / o2));  // Division
            Console.WriteLine("The Modulus of(%) these two numbers is : " + (o1 % o2));  // Modulus


            // HINT (Comparison Operators)
            // ( == ) Equal to x == y
            // ( != ) Not Equal x != y

            // HINT (Logic Operators)
            // ( && ) and gate
            // ( || ) or gate
            // ( ! ) not gate
        }















    }
}