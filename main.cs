using System;

class MainClass {
  public static void Main (string[] args) {
    IntegerPower();
  }
  public static void IntegerPower()
  { 
    Console.WriteLine("What is the base?");
    double Base = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is the exponent.");
    double exponent = Convert.ToDouble(Console.ReadLine());
    double power = Base;
    while(exponent > 1)
    {
      Base = Base * power;
      exponent--;
    }
    Console.WriteLine("The total is " + Base + ".");
  }
}