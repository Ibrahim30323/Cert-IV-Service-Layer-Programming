using System;
using System.Globalization;

namespace Exception_handling_task
{
    class Program_exec
    {
        static void Main(string[] args)
        {
           
           try
           {
            DateTime actualDate1 = DateTime.Parse("03/08/2020", new CultureInfo("en-AU"));
            DateTime actualDate2 = DateTime.Parse("23/02/2020", new CultureInfo("en-AU"));
            
            Console.WriteLine("Enter data for people entering a classroom:");
            Console.Write("Enter two room numbers: ");
            string roomNumbers = Console.ReadLine();
            
           
                 if (roomNumbers == "TD224, AGSE111") {
                     Console.Write("Type two names: ");
                     string twoFullNames = Console.ReadLine();
                     if (twoFullNames == "John Doe, Jane Black") {
                         Console.Write("Enter first date: ");  
                         DateTime date1EnteredFromUser = DateTime.Parse(Console.ReadLine()); // 'FormatException' occurs when user input argument syntax is invalid. E.g: Typing the letter 'e'.
                         if (date1EnteredFromUser == actualDate1) {
                            Console.Write("Enter second date: ");
                         DateTime date2EnteredFromUser = DateTime.Parse(Console.ReadLine()); // Same as above
                            if (date2EnteredFromUser == actualDate2) {
                                Console.Write("Enter two 24 hour format times: ");
                                string twoTimesEntered = Console.ReadLine();
                                if (twoTimesEntered == "14:30, 08:20") {
                                    
                                    Console.Write("Type first number of minutes person stayed: ");
                                    byte firstMinutesEntered = Convert.ToByte(Console.ReadLine()); /* byte data type means: only store 0 to 255*/  
                                   if (firstMinutesEntered == 12) {                                // If typed 256 or over then 'ThrowOverflowException' occurs
                                    Console.Write("Type second number of minutes person stayed: ");
                                    byte secondMinutesEntered = Convert.ToByte(Console.ReadLine()); 
                                   if (secondMinutesEntered == 15) {
                                    Console.Write("Type last number of minutes person stayed: ");
                                   int lastMinutesEntered = Convert.ToInt32(Console.ReadLine()); 
                                   if (lastMinutesEntered == 300) {
                                            Console.WriteLine("Well done, all correct!");
                                   } else {
                                       Console.WriteLine("Wrong");
                                       Console.ReadLine();
                                       return; 
                                   }
                                   } else {
                                       Console.WriteLine("Wrong");
                                       Console.ReadLine();
                                       return; 
                                   }
                                   } else {
                                       Console.WriteLine("Wrong");
                                       Console.ReadLine();
                                       return; 
                                   }
                                  } else {
                                    Console.WriteLine("Wrong");
                                    Console.ReadLine();
                                    return; 
                                }
                                } else {
                                    Console.WriteLine("Wrong");
                                    Console.ReadLine();
                                    return;  
                                }  
                                } else {
                                    Console.WriteLine("Wrong");
                                    Console.ReadLine();
                                    return; 
                                }
                            
                            
                            } else {
                               Console.WriteLine("Wrong");
                               Console.ReadLine();
                               return; 
                            }         
                         } else {
                             Console.WriteLine("Wrong");
                             Console.ReadLine();
                             return; 
                            }
             }
             catch (Exception e) {
                 Console.WriteLine(e.Message);
             } 

             Console.WriteLine("If you see this message, it means that the application has not been terminated");
             Console.ReadLine();
             Console.WriteLine("Now press any key to terminate the program");    
             Console.ReadLine();   
        }        
    }
}
