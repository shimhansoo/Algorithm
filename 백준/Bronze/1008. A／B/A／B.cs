using System;

class HelloWorld {
  static void Main() {
    string[] s = Console.ReadLine().Split();
    double a = double.Parse(s[0]) / double.Parse(s[1]);
    Console.WriteLine(a);
  }
}
