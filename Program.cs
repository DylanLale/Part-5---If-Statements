using System.Reflection.Emit;
using System.Transactions;

namespace Part_5___If_Statements
{
    internal class Program
    {




        static void Main(string[] args)
        {




            int dubs;
            int age, catagory, money, notdubs, bet, total, roll, roll2;
            
            Random generator = new Random();


            Console.WriteLine("Enter your age");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else if (age > 12)
            {
                Console.WriteLine("You are a teen");
            }



            else if (age >= 12)
            {
                Console.WriteLine("You are a Preteen");
            }


            else if (age >= 10)
            {
                Console.WriteLine("You are a child");
            }


            else if (age <= 5)
            {
                Console.WriteLine("You are a toddler");
            }
            


            //hurricane
            Console.WriteLine();
            Console.WriteLine("Enter a catagory of hurricane");
            catagory = Convert.ToInt32(Console.ReadLine());

            if (catagory == 1)
            {
                Console.WriteLine("74 - 95mph");
                Console.WriteLine("64 - 82 knots");
                Console.WriteLine("119 - 153km/hr");
            }
            else if (catagory == 2)
            {
                Console.WriteLine("96 - 110mph");
                Console.WriteLine("83 - 95 knots");
                Console.WriteLine("154 - 177km/hr");
            }




            else if (catagory == 3)
            {
                Console.WriteLine("111 - 130mph");
                Console.WriteLine("96 - 113 knots");
                Console.WriteLine("178 - 209km/hr");
            }



            else if (catagory == 4)
            {
                Console.WriteLine("131 - 155mph");
                Console.WriteLine("114 - 135 knots");
                Console.WriteLine("210 - 249km/hr");
            }



            else if (catagory == 5)
            {
                Console.WriteLine("Greater than 155mph");
                Console.WriteLine("Greater than 135 knots");
                Console.WriteLine("Greater than 249km/hr");
            }
            else
            {
                Console.WriteLine("That doesnt exist");
            }
            

            //dice
            Console.WriteLine("You have $100 to bet on dice rolls.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You will select how much money to bet and depending on your roll, you will win or lose your money");
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Dice Roll Multipliers");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Doubles: Your bet doubles");
            Console.WriteLine("Not Doubles: Win half of your bet");
            Console.WriteLine("Even Sum: Win your bet");
            Console.WriteLine("Odd Sum: Win your bet");
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Enter your bet");
            bet = Convert.ToInt32(Console.ReadLine());
            money = 100;
            total = money - bet;
            roll = (generator.Next(1, 7));
            roll2 = (generator.Next(1, 7));
            
            DrawDice(roll);
            DrawDice(roll2);



            //doubles
            if (roll == roll2) 
            {
                dubs = (bet * 2);
                money = (100 + dubs);
                Console.WriteLine($"You now have" + money);
            }

            //even
            else if (roll + roll2 == 2)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 4)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 6)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 8)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 10)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 12)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            //odds

            else if (roll + roll2 == 1)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 3)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 5)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 7)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 9)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            else if (roll + roll2 == 11)
            {
                money = (100 + 10);
                Console.WriteLine($"You now have: " + money);
            }

            //not doubles
            else if (roll != roll2)
            {
                notdubs = (bet / 2);
                money = (100 - notdubs);
                Console.WriteLine($"You now have: " + money);
            }

        }







        public static void DrawDice(int face)
        {
            if (face == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (face == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (face == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (face == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (face == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (face == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }


        }

        

       
        }
    } 
