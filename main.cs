using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Please enter a base: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter an exponent: ");
    int e = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"\nAnswer = {integerPower(b, e)}");
  }

  public static int integerPower(int b, int e) {

    int answer = b;
    int i = 1;

    while (i < e) {
      answer *= b;
      i++;
    }

    return answer;
  } 
}