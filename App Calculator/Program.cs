using App_Calculator;

ArithmeticLogic arithmeticLogic = new ArithmeticLogic();
bool condition = true;
string option;
string a;
string b;

Console.WriteLine("Welcome to App calculator\n");
Console.WriteLine("Please choose one option of the list\n");

while (condition)
{
    Console.WriteLine("Enter first number: ");
    a = Console.ReadLine();
    if (!arithmeticLogic.ConvertNumber(a)) { Console.WriteLine("Please write a valid number\n"); continue; }
    Console.WriteLine("Enter second number: ");
    b = Console.ReadLine();
    if (!arithmeticLogic.ConvertNumber(b)) { Console.WriteLine("Please write a valid number\n"); continue; }
    arithmeticLogic.ConvertNumber(a, b);

    Console.WriteLine("Arithmetic list operations: \n1. A - addition. \n2. S - subtraction. \n3. M - multiplication. \n4. D - division. \n5.Mo - modulo. \nE - Exit.\n");
    option = Console.ReadLine();

    switch (option)
    {
        case "A":
            Console.WriteLine($"The answer is: {arithmeticLogic.Addition()}\n");
            break;
        case "S":
            Console.WriteLine($"The answer is: {arithmeticLogic.Subtraction()}\n");
            break;
        case "M":
            Console.WriteLine($"The answer is: {arithmeticLogic.Multiplication()}\n");
            break;
        case "D":
            Console.WriteLine($"The answer is: {arithmeticLogic.Division()}\n");
            break;
        case "Mo":
            Console.WriteLine($"The answer is: {arithmeticLogic.Modulo()}\n");
            break;
        case "E":
            condition = false;
            break;
        default:
            Console.WriteLine("You choose a wrong option, please try again.");
            break;
    }
}
