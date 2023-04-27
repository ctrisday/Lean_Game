using System.Text;
using System;

class Program
{
    static void Main(string[] args)
    {
        string b = "Huynh";
        b = b + " Cao Tri";
        StringBuilder a = new StringBuilder("How");
        Console.WriteLine(a.Append("Tri"));
        Console.WriteLine(b);
    }
}