namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int catagory;
            Console.WriteLine("Enter your age");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18);
                Console.WriteLine("You are an adult");
            
            if (age > 12);
                Console.WriteLine("You are a teen");
            

            if (age >= 12);
                Console.WriteLine("You are a Preteen");
            
            if (age >= 10);
                Console.WriteLine("You are a child");
            
            if (age <= 5);
                Console.WriteLine("You are a toddler");


            //hurricane
            Console.WriteLine();
            Console.WriteLine("Enter a catagory of hurricane");
            catagory = Convert.ToInt32(Console.ReadLine());

            if (catagory == 1);
            Console.WriteLine("74 - 95mph");
            Console.WriteLine("64 - 82 knots");
            Console.WriteLine("119 - 153km/hr");

            if (catagory == 2);
            
            Console.WriteLine("96 - 110mph");
            Console.WriteLine("83 - 95 knots");
            Console.WriteLine("154 - 177km/hr");

            if (catagory == 3) ;
            Console.WriteLine("111 - 130mph");
            Console.WriteLine("96 - 113 knots");
            Console.WriteLine("178 - 209km/hr");

            if (catagory == 4) ;
            Console.WriteLine("131 - 155mph");
            Console.WriteLine("114 - 135 knots");
            Console.WriteLine("210 - 249km/hr");

            if (catagory == 5) ;
            Console.WriteLine("Greater than 155mph");
            Console.WriteLine("Greater than 135 knots");
            Console.WriteLine("Greater than 249km/hr");

        }
    }
}