namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintStory();
            //int myResult = AddNums(2, 2);
            //Console.WriteLine(myResult);
            Console.WriteLine(AddNums(2, 2));
            Console.WriteLine(SubtractNums(2, 2));
            Console.WriteLine(DividNums(2, 2));
            Console.WriteLine(MultiplyNums(2, 2));
        }

        public static void PrintStory()
        {
            Console.WriteLine("what is your name?");
            var username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}, what is your favorite color");
            var color = Console.ReadLine();
            Console.WriteLine("what is your favorite animal");
            var animal = Console.ReadLine();
            Console.WriteLine("what is your favorite band");
            var band = Console.ReadLine();
        }

        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubtractNums(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int DividNums(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int MultiplyNums(int num1, int num2)
        {
            return num1 * num2;
        }

            


        
    }
}