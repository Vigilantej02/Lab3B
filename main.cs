using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter your name");
    var name = Console.ReadLine();
    Console.WriteLine ("Please enter your sales amount");
    var salesAmount = Console.ReadLine();
    double salesAmount1 = Convert.ToDouble(salesAmount);
    double comission = 200 + (0.09*salesAmount1);
    Console.WriteLine (name +"'s comission is $" + comission);
    if (salesAmount1 <= 2999){
      Console.WriteLine("Your performance is Poor");
    }
    else {
      if (salesAmount1 <= 4999){
        Console.WriteLine("Your performance is Average");
      }
      else{
        if (salesAmount1 <= 9999){
          Console.WriteLine("Your performance is Good");
        }
        else {
          if (salesAmount1 <= 14999){
            Console.WriteLine("Your performance is Excellent");
          }
          else{
            if (salesAmount1 >= 15000){
              Console.WriteLine("Your performance is Outstanding!");
            }
          }
        }
      }
    }
  }
}