﻿using System;

namespace CSharpExample
{
    class Program
    {
        static void Main(string[] args)
       {
           
           int x = 30;
            Console.WriteLine("Hello Toyin" + x);

            if (x>30) 
            {
                Console.WriteLine ("x is less than thirty");

            }

            else if (x==30)
            {
                Console.WriteLine("X is thirty");

            }

            else
            {
                Console.WriteLine("X is greater than thirty");
            }

            int a =3;
               switch (a)

               {
                case 1:
                   Console.WriteLine("Value is 1!");
                   break;
                case 2:
                    Console.WriteLine("Value is 2!");
                    break;
                case 3:
                    Console.WriteLine("Value is 3!");
                    break;
                default:
                    Console.WriteLine("Uh oh, it is another value!");
                    break;

               }
       }

        
    }
}
