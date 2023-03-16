using System;

class HelloWorld {
  static void Main() {
    string[] T = Console.ReadLine().Split();

    long[] a = new long[3];
    long result = 0;
    for(int i = 0; i < T.Count(); i++)
    {
      a[i] = long.Parse(T[i]);
      result += a[i];
    }
    Console.WriteLine(result);
  }
}
