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
            // Operators();
            // MathOPs();
            // Strings();
            // Booleans();
            // ifCond();
            // switchCase();
            // WhileLoop();
            ForLoop();

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

        static void MathOPs()
        {
            // finding the highest number between two inputs
            double m1, m2;

            // first input
            Console.Write("Enter the first number : ");
            m1 = Convert.ToDouble(Console.ReadLine());

            // second input
            Console.Write("Enter the second number : ");
            m2 = Convert.ToDouble(Console.ReadLine());

            // output
            Console.WriteLine("The highest number in these two numbers is : {0}", Math.Max(m1, m2)); // Max 

            Console.WriteLine("The Lowest number in these two numbers is : {0}", Math.Min(m1, m2));  // Min

            Console.WriteLine("The square root of the first number is : {0}", Math.Sqrt(m1));  // Square root

            Console.WriteLine("The Absolute of the first number is : {0}", Math.Abs(m1));  // Absolute

            Console.WriteLine("The nearest number of the first number is : {0}", Math.Round(m1));  // Square root
        }

        static void Strings()
        {
            // input
            Console.Write(" Enter any text : ");
            string s = Console.ReadLine();

            // output
            Console.WriteLine("The Length of this text is : {0}", s.Length); // text length

            Console.WriteLine("text converted to uppercase : {0}", s.ToUpper()); // all text in uppercase

            Console.WriteLine("text converted to lowercase : {0}", s.ToLower()); // all text in lower case

            Console.WriteLine("text converted to Uppercase and Lowercase together : {0}", string.Concat(s.ToUpper(), s.ToLower())); // mixing lowercase and uppercase with Concat

            string s2 = "SINGLE";
            string s3 = "CODE";

            string ss = $"Thats a whole text in a {s2} {s3}";
            Console.WriteLine(ss);

            Console.WriteLine("The second letter in this text is : {0}", s[1]);
        }

        static void Booleans()
        {
            Console.WriteLine(10 > 7);
        }

        static void IfCond()
        {
            // if is ez im too lazy to go for it tbh
        }

        static void switchCase()
        {
            // getting weekday by number

            // declaring vars
            int w = 1;

            // input
            Console.Write("Enter the number of the day u want : ");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // switch case
            switch (w)
            {
                case 1:
                    Console.WriteLine("Its Saturday!!");
                    break;

                case 2: 
                    Console.WriteLine("Its Sunday!!");
                    break;

                case 3:
                    Console.WriteLine("Its Monday!!");
                    break;

                case 4:
                    Console.WriteLine("Its Tuesday!!");
                    break;

                case 5:
                    Console.WriteLine("Its Wednesday!!");
                    break;

                case 6:
                    Console.WriteLine("Its Thursday!!");
                    break;

                case 7:
                    Console.WriteLine("Its Friday!!");
                    break;
            }

        }

        static void WhileLoop()
        {
            // the factorial of given number by the user

            //declaring vars
            int wl = 0, wl2 = 0, ws = 0;

            // input
            Console.Write("U want the factorial of ");
            wl = wl2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // while loop output
            Console.Write("Well, the factorial of {0} is ", wl);


            while (wl > 0)
            {
                ws += wl;
                wl--;
            }
            Console.WriteLine(ws);

        }

        static void ForLoop()
        {
            /* 
             
             for (statement 1; statement 2; statement 3) 
{
                // code block to be executed
            } 

            */ // Lazy Person ¯\_(ツ)_/¯

            // nvm there's foreach loop '_'

            string[] idk = {"Idk", "Damn", "Broo"};

            // foreach loop
            foreach(string id in idk)
            {
                Console.WriteLine(id);
            }
        }












    }
}