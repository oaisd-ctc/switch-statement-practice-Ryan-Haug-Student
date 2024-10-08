public class Program{
    public static void Main(string[] args){

        Console.Clear();

        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        switch (number){
            case 1:
                Console.WriteLine("Number 1");
                break;
            case 2:
                Console.WriteLine("Number 2");
                break;
            case 3:
                Console.WriteLine("Number 3");
                break;
            case 4:
                Console.WriteLine("Number 4");
                break;
            case 5:
                Console.WriteLine("Number 5");
                break;
            case 6:
                Console.WriteLine("Number 6");
                break;
            case 7:
                Console.WriteLine("Number 7");
                break;
            case 8:
                Console.WriteLine("Number 8");
                break;
            case 9:
                Console.WriteLine("Number 9");
                break;
            case 10:
                Console.WriteLine("Number 10");
                break;
        }

        if (number > 10){
            Console.WriteLine("Please enter a number less than 10");
        }

    }
}
