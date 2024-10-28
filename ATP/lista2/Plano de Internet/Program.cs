using System;

class Program {
  public static void Main (string[] args) {
    int x = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    int[] M = new int[n];
    int quota = x;

    for(int i = 0; i < n; i++){
     M[i] = int.Parse(Console.ReadLine());
     quota += x - M[i];
    }
    Console.WriteLine(quota);
  }
}