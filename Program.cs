namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18);
            
                Console.WriteLine("You are an adult");
            

            else if (age > 12);
            
                Console.WriteLine("You are a teen");
            

            else if (age >= 12) ;
            
                Console.WriteLine("You are a Preteen");
            

            else if (age <= 10) ;
            
                Console.WriteLine("You are a child");
            

            else if (age <= 5) ;
            
                Console.WriteLine("You are a toddler");
            

        }
    }
}