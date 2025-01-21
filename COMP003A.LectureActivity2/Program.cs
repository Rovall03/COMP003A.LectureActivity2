//Author: Rosa Ovalle
//Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: A program demonstrating statments, variables, and operatoors.


namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //steps 3.1: Declare and initialize varibles
            string userName; // variable to store the users name
            int usersAge; //variable to store users age
            double productPrice;//variable to store the product price 
            bool isStudent;// variable to store if the user is a student (true / false)
           
            
            //promt thr usser to enter their age
            Console.WriteLine("Enterr Your Name: ");
            userName = Console.ReadLine();//read  and assign the users input to userName 

            //Promt the user to enter their age 
            Console.WriteLine("Enter your age: ");
            usersAge = int.Parse(Console.ReadLine());//Convert and assign the user's input to userAge

            //Promt the user to enter the product price
            Console.WriteLine("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine());//convert and assign the users input to isStudent 

            //prompt the user to indicate if they are a student
            Console.WriteLine("Are you a student? (true / false): ");
            isStudent= bool.Parse(Console.ReadLine());//convert and assign the users input to isStudent

            //steps 3.2: Preform calculation
            int futureAge = usersAge + 5;//calculate the users age in 5 years
            bool isAdult = usersAge >= 18;// determine if the user is 18 or older
            bool isAdultStudent = isStudent && isAdult;//determaine if the user is both a student and an adult

            //steps3.3:Display outputs using string interpolation 
            Console.WriteLine($"\nHello{userName}! ");//greet the user with their name 
            Console.WriteLine($"You are currently {usersAge} years old. In 5 years, you will be {futureAge}.");// displays current and future age
            Console.WriteLine($"Are you 18 or older? {isAdult}");//display if the user is 18 or older
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}");//displays if the user is both a student and an adult 



        }
    }
}
