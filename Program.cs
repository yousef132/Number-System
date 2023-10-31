using System;
using System.Collections;
using System.Numerics;
using System.Reflection;

namespace Number_System
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Exceptions
           // var Binary = new BinarySystem("10123");
           // var Decimal = new DecimalSystem("1012c3");

           
            var d = new DecimalSystem("123");    
            var binary = d.To(NumberBase.BINARY);
            var octal = d.To(NumberBase.OCTAL);
            var hex = d.To(NumberBase.HEXADECIMAL);


            Console.WriteLine("In debug");
            Console.WriteLine($"({d.Value})10 = ({binary}) {(int)NumberBase.BINARY}");
            Console.WriteLine($"({d.Value})10 = ({octal}) {(int)NumberBase.OCTAL}");
            Console.WriteLine($"({d.Value})10 = ({hex}) {(int)NumberBase.HEXADECIMAL}");
        }

    }
}
