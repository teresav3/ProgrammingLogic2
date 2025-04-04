namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

 //Part 1 
        int myNumA = 12345;
        Console.WriteLine(myNumA);

        double myNumB = 12.34D;
        Console.WriteLine(myNumB);

        float myNumC = 1.23f;
        Console.WriteLine(myNumC);

        char myChar = 'T';
        Console.WriteLine(myChar);

        bool isItspring = true;
        Console.WriteLine(isItspring);

        string myString = "Happy Spring";
        Console.WriteLine(myString);

        //Part 2

        double myDouble = 9.78;
        int myInt = (int)myDouble;
        Console.WriteLine(myInt);

        int myIntA = 9;
        Console.WriteLine(Convert.ToString(myIntA));

        bool myBool = true;
        Console.WriteLine(Convert.ToString(myBool));

        //Part 3

        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine(); 
        Console.WriteLine ("Hello " + name + "!");

        Console.WriteLine("Enter your age: ");
        string ageInt = Console.ReadLine();
        int age = Convert.ToInt32(age);
        Console.WriteLine("You are " + ageInt + "years old.");

        //Part 4

        int num1 = 10;
        int num2 = 15;

        int sum1 = num1 + 10;

        int sum2 = num2 - 2;

        int sum3 = num1 * 3;

        int sum4 = num2 / 2;

        int sum5 = num1 % 5;

        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);
        Console.WriteLine(sum4);
        Console.WriteLine(sum5);

        //Part 5

        float myNum1 = 1.123456789F;
        Console.WriteLine(myNum1);

        double myNum2 = 1.123456789D;
        Console.WriteLine(myNum2);

        //Part 6 

        int x = 10;
        x++;
        Console.WriteLine(x);
        x--;
        Console.WriteLine(x); 

    }
}
