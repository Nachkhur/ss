using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Dynamic;
using System.Security;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main(string[] args)
    {
        string[] arr = {"Хирург", "Терапевт","Лор","Онколог","Кардиолог"};
        Random rd = new Random();
        for (int i = 0; i < 10; i++)
        {
            int rdIndex = rd.Next(arr.Length);
            var rdValue = arr[rdIndex];
            Console.WriteLine(rdValue);
        }
    }
}