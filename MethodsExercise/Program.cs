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
            Console.WriteLine($"what is your name?");
            var username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}, what is your Favorite Color?");
            var FavoriteColor = Console.ReadLine();
            Console.WriteLine($"favorite animal?");
            var FavoriteAnimal = Console.ReadLine();
            Console.WriteLine($"favorite band?");
            var FavoriteBand = Console.ReadLine();
         

          
            Console.WriteLine($"one day {username} was walking in the woods and saw his {FavoriteAnimal} that was his favorite color {FavoriteColor} with is favorite band {FavoriteBand}");
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