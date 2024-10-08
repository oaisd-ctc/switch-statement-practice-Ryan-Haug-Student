public class Program{
    public static void Main(string[] args){

        Console.Clear();

        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        switch (number){
            case 0:
                Console.WriteLine("Your number is 0");
                break;
            case 1:
                Console.WriteLine("Your number is 1");
                break;
            case 2:
                Console.WriteLine("Your number is 2");
                break;
            case 3:
                Console.WriteLine("Your number is 3");
                break;
            case 4:
                Console.WriteLine("Your number is 4");
                break;
            case 5:
                Console.WriteLine("Your number is 5");
                break;
            case 6:
                Console.WriteLine("Your number is 6");
                break;
            case 7:
                Console.WriteLine("Your number is 7");
                break;
            case 8:
                Console.WriteLine("Your number is 8");
                break;
            case 9:
                Console.WriteLine("Your number is 9");
                break;
            case 10:
                Console.WriteLine("Your number is 10");
                break;
        }

        if (number > 10){
            Console.WriteLine("Please enter a number less than 10");
        }

    }
}
