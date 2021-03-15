using System;
 
/*
Write a program that reads a time from the console.
 Time is represented by two integers – hours and minutes.
 Each of them will be written from a new line, hours first.
  The hour must be a value between 0 and 23, and the minutes between 0 and 59.
   If the user inputs an incorrect value for either variable, 
   the prograrm should output: 
   "This is not a valid time. Try again!", 
   otherwise: "The time is {hours}:{minutes}" 
   The program should continue to ask for and read values for the hours
    and minutes until the user inputs valid values for both of them.
 
*/
 
namespace Time
{
    class Program
    {
 
        //set up a checkBoundaries function
        //which take 2 parameters - min value and a maximum
        public bool checkBoundaries (int minV, int maxV, int numberV) {
            bool answer = true; //set it to true by default
            //contains the answer to the question is input between 0-12/0-59
 
            if (minV<=numberV && numberV<=maxV)
                Console.WriteLine("Your input is valid");
 
            else { 
                Console.WriteLine("Your input is invalid. Try again!");
                answer = false;
            }//end else statement
 
            return answer;  //true or false
        }//end checkBoundaries
 
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
 
            //input - what sort of input am I working with
            //ask for input
            //make sure the input is not Null/or Empty
            //or else ask the question again
            //then check if input is Numerical/Integer
            //or ask for input again
            //check the boundaries of my input
 
            Console.WriteLine("Input your time, hours");
            var timeAsString = Console.ReadLine();
 
            int timeHours;
            while(string.IsNullOrEmpty(timeAsString)) {
                  Console.WriteLine("Empty string. Try again!!");
                  timeAsString = Console.ReadLine();            
 
            }//end while check if string is empty
 
            while(!int.TryParse(timeAsString, out timeHours)) {
                    Console.WriteLine("This is not an input! Please try again");
                    timeAsString = Console.ReadLine();
            }//end while check if conversion to integer works
            //output - what is the purposeof this program?
 
            //functions/parameters - validating input
            //validate hours
            Program p = new Program();
            Console.WriteLine($"Check boundaries returned {p.checkBoundaries(0, 12, timeHours)}");
 
 
 
        }//end Main
    }//end Program
}//end namespace
 
