/*Author Charlie Yingling                                           Date 10/25/21
Create a C# app to calculate the hypotenuse of a triangle by calling the method DetermineHypotenuse. Display the hypotenuse.
*/
using System;

class Program {
  public static double DetermineHypotenuse (double s1,double s2) {
      return Math.Sqrt((s1 * s1) + (s2*s2));
  }
  public static void Main (string[] args) {
        Console.WriteLine("Enter side1 of triangle:");
  double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side2 of triangle:");
  double side2 = Convert.ToDouble(Console.ReadLine());
  double Hypotenuse = DetermineHypotenuse(side1,side2);
        Console.WriteLine("Hypotenuse of triangle: {0}", Hypotenuse);
  }
}