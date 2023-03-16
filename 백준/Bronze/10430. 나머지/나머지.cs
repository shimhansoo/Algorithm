using System;

class HelloWorld {
  static void Main() {
    string[] s = Console.ReadLine().Split();
    int A = int.Parse(s[0]);
    int B = int.Parse(s[1]);
    int C = int.Parse(s[2]);

    /*
    Console.Write("{A}  ");
    Console.Write("{B}  ");
    Console.Write("{C}  ");
    */
    Console.WriteLine($"{(A+B)%C}");
    Console.WriteLine($"{((A%C) + (B%C))%C}");
    Console.WriteLine($"{(A*B)%C}");
    Console.WriteLine($"{((A%C) * (B%C))%C}");
  }
}
