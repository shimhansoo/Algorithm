// See https://aka.ms/new-console-template for more information
using System;

class HelloWorld {
  static void Main() {
    string[] s = Console.ReadLine().Split();
    Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
  }
}
