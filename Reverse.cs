using System;

class Reverse{

	public static void Main(String[] args){

	Console.WriteLine("Enter the number:");
	string number = Console.ReadLine();
	char[] arrOfNumbers = number.ToCharArray();
	Array.Reverse(arrOfNumbers);
	string reverseNumber = new String(arrOfNumbers);
	int inputNumber = Convert.ToInt32(reverseNumber);
	Console.WriteLine("The reversed number is :" + inputNumber);
}
}

