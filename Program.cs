using System;

namespace CSharpExample
{
    class Program
    {
        static void Main(string[] args)

       {
           int [] myarray = new int[5] {2,4,6,5,2};
           myarray[1] = 2;
           Console.WriteLine(myarray[0]);
           Console.WriteLine(myarray[1]);
           Console.WriteLine( myarray[3]); 

foreach (int e in myarray)
{
    Console.WriteLine (e);
}
{
    
}



            
                int [] myarray1 = new int[4]{3,5,7,9};
                
                for (int m = 0; m < 4; m++)
            
                {
                    Console.WriteLine(myarray1[m]);       
                }

                //Lets collect users input

                Console.WriteLine("Please enter your name");
                string myname = Console.ReadLine();
                Console.WriteLine("Thank you," + myname);



           
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
               
                    MyMethod();
       }

       static void MyMethod()
       {

           Console.WriteLine("Test!");
       }
    }
}
