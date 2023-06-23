
#region Task1
//int multiplication(int x, int y)
//{
//	for (int i = x; i <=y; i++)
//	{
//		Console.WriteLine($"Table multiplication number {i} ");
//		for (int j = 1; j <= 10; j++ )
//		{
//            Console.WriteLine(i + " * " + j + " = " + i * j);
//        }
//	}
//	return 0; 
//}

//int m = multiplication(1, 6);

#endregion

#region Task2
//using Exam2;

//int firstNumber;
//int secondNumber; 
//char operation;

//Console.WriteLine("The first number is: ");
//firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("The operation is: ");
//operation = Convert.ToChar(Console.ReadLine());

//Console.WriteLine("The second number is: ");
//secondNumber = Convert.ToInt32(Console.ReadLine());

//var calculator = new Calculator(firstNumber, secondNumber);


//switch (operation)
//{
//    case '+':
//        Console.WriteLine($"{firstNumber} + {secondNumber} = {calculator.Sum()}");
//        break;
//    case '-':
//        Console.WriteLine($"{firstNumber} - {secondNumber} = {calculator.Subtract()}");
//        break;
//    case '*':
//        Console.WriteLine($"{firstNumber} * {secondNumber} = {calculator.Multiplication()}");
//        break;
//    case '/':
//        Console.WriteLine($"{firstNumber} / {secondNumber} = {calculator.Division()}");
//        break;
//    default:
//        Console.WriteLine("Choose operation(+, -, *, / )"); 
//        break;
//}
#endregion

#region Task3

using Exam2;

User[] users = new User[]
    {
        new User("Shahrom", "Sharipov", "Shahrom", "123"),
        new User("Shodmon", "Sangov", "Shodmon", "321"),
        new User("Shodravon", "Shodiev", "Shoravon", "12345"),
        new User("Shams", "Aliev", "Shams", "54321"),
        new User("Shoh", "Shoev", "Shoh", "1111"),

    };

while(true)
{
    Console.Write("Enter UserName:");
    string username = Console.ReadLine();
    Console.Write("Enter Password:");
    string password = Console.ReadLine();  

    bool login = false;
    
    for(int i = 0;i <users.Length; i++ )
    {
        if (users[i].Login(username, password))
        {
            login = true;
            Console.WriteLine($"Login successful! Welcome Mr " +
                $"{users[i]._firsName} {users[i]._lastName}");
            break;
        }
    }
    if (!login)
    {
        Console.WriteLine("Login Failed try again"); 
    }
}


#endregion


