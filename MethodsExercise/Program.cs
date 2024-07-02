namespace MethodsExercise
{
    public class Program
    {    
         
            
            
        static void Main(string[] args)
        {
            FavStory();
            int added = Add(4, 2);
            Console.WriteLine(added);
            int subtracted = Subtract(5, 1);
            Console.WriteLine(subtracted);
            int multiplied = Multiply(5, 8);
            Console.WriteLine(multiplied);
            int divided = Divide(6, 2);
            Console.WriteLine(divided);
            int result = Sum(5, 4, 2, 3, 8);
            Console.WriteLine(result);
               
        }

        public static void FavStory()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Okay. Who is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("I'm a big fan too! Last question, what is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"One of the strangest things happened this summer at a {favBand} concert. A {favAnimal} with {favColor} hair ran across the stage and jumped on {userName}, who was sitting in the front row!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2) 
        {

            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {

            return num1 / num2; 
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            return sum;
        }


        
        
      
    }
}
