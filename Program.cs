using System;

System.Console.WriteLine("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"1st number is greater than 2nd number: {firstNumber > secondNumber}");
System.Console.WriteLine($"1st number is greater than or equal to 2nd number: {firstNumber >= secondNumber}");
System.Console.WriteLine($"1st number is less than 2nd number: {firstNumber < secondNumber}");
System.Console.WriteLine($"1st number is less than or equal to 2nd number: {firstNumber <= secondNumber}");
System.Console.WriteLine($"Number are equal: {firstNumber == secondNumber}");
System.Console.WriteLine($"Number are not equal: {firstNumber != secondNumber}");
