using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Transactions;

namespace Assignment_Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            /*
            1 - Write a program that takes a number from the user then print yes if that
               number can be divided by 3 and 4 otherwise print no.
                    Example(1)
                    Input: 12
                    Output: Yes
                    Example(2)
                    Input: 9
                    Output: No
            */

            //Console.WriteLine(" Please Enter Number : ");
            //double number = double.Parse(Console.ReadLine());

            //if (number % 3 == 0 & number % 4 == 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine(" Yes ");
            //    Console.WriteLine($" Number is true => {number} ");

            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine(" No ");
            //    Console.WriteLine($" Number is False => {number}  ");

            //}

            #endregion

            #region Q2
            /*
             * 2- Write a program that allows the user to insert an integer then print
                negative if it is negative number otherwise print positive.
                    Example (1)
                    Input: -5
                    Output: negative
                    Example (2)
                    Input: 10
                    Output: positive
             
             */

            //Console.WriteLine(" Please Enter Number : ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number < 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine(" Negative ");
            //    Console.WriteLine($" Number is Negative => {number}");
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine(" Positive ");
            //    Console.WriteLine($" Number is Positive => {number}");
            //}
            #endregion

            #region Q3

            /*
             * 3- Write a program that takes 3 integers from the user then prints the max
                element and the min element.
                Example (1)
                Input:7,8,5
                Output:
                max element = 8
                min element = 5
                Example (2)
                Input: 3 6 9
                Outputs:
                Max element = 9
                Min element = 3
             */


            //Console.WriteLine(" Please Enter Number1 : ");
            //int.TryParse(Console.ReadLine(), out int number1);

            //Console.WriteLine(" Please Enter Number2 : ");
            //int.TryParse(Console.ReadLine(), out int number2);

            //Console.WriteLine(" Please Enter Number3 : ");
            //int.TryParse(Console.ReadLine(), out int number3);


            //int max, min;

            //if (number1 >= number2 && number1 >= number3)
            //      max = number1;

            //else if (number2 >= number1 && number2 >= number3)
            //    max = number2;

            //else
            //    max = number3;



            //if (number1 <= number2 && number1 <= number3)
            //    min = number1;

            //else if (number2 <= number1 && number2 <= number3)
            //    min = number2;

            //else
            //    min = number3;

            //Console.WriteLine(" Max Element => " + max);
            //Console.WriteLine(" Min Element => " + min);


            #endregion

            #region Q4

            /*
             4- Write a program that allows the user to insert an integer number then
                check If a number is even or odd.
             */


            //Console.WriteLine("please, Enter Number : ");
            //  int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //    Console.WriteLine($"{number} => Number is Even");
            //else
            //    Console.WriteLine($"{number} => Number is odd");





            // even only لو عاوز اخلي المستخدم يدخل رقم 

            //int number;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine(" Please Enter Number : ");
            //  isparsed = int.TryParse(Console.ReadLine(), out  number);
            //}
            //while (number %2 == 1 || isparsed == false);
            //{
            //    Console.WriteLine($" {number} is even Number " );
            //}

            #endregion

            #region Q5

            /*
             * 5- Write a program that takes character from the user then if it is a vowel
              chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
                    Example (1)
                    Input: O
                    Output: vowel
                    Example (2)
                    Input: b
                    Output: Consonant
             */
            // char[] character = { 'a', 'e', 'I', 'o', 'u' };



            //       ********    if    ************


            //Console.WriteLine(" Please , Enter a character: ");
            //char.TryParse(Console.ReadLine(), out char ch);


            //if (ch == 'a' || ch == 'o' || ch == 'e' || ch == 'u' || ch == 'I')

            //    Console.WriteLine(" vowel ");

            //else

            //    Console.WriteLine(" consonant ");

            // **********************************************//

            //               switch 


            //Console.WriteLine(" Please , Enter a character: ");
            //char.TryParse(Console.ReadLine(), out char ch);

            //switch(ch)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'o':
            //    case 'I':
            //    case 'u':
            //        Console.WriteLine(" vowel");
            //        break;

            //        default:
            //        Console.WriteLine("consonant");
            //        break ;


            #endregion

            #region Q6
            /*
             *  Write a program that allows the user to insert an integer then print all
                numbers between 1 to that number.
                Example
                Input: 5
                Output: 1, 2, 3, 4, 5
             
             */

            //Console.WriteLine(" Enter Number : ");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 1 ; i <= number; i++)
            //{
            //    Console.Write(i + ", " );  // بتطبع غلي نفس السطر     
            //}

            #endregion

            #region Q7

            /*
             * 7- Write a program that allows the user to insert an integer then
            print a multiplication table up to 12.
              Example
              Input: 5
              Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            */

            /// ************* for ***********

            //Console.WriteLine(" Enter Number : ");
            //int.TryParse(Console.ReadLine(), out int number);


            //for (int i = 1 ; i <=  12;  i++)
            //{
            //    ///   eny one true
            //    ///   
            //    Console.WriteLine(number + " X " + i + " = " +(number*i));
            //    Console.Write((number * i)); // 1=>  Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //}


            /// ***************** do while **************

            //Console.WriteLine(" Enter Number : ");
            //int.TryParse(Console.ReadLine(), out int number);

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(number + " * " + i + " = " + (i*number) );
            //    i++;
            //}
            //while (i <= 12);
            #endregion

            #region Q8

            /*
             * 8- Write a program that allows to user to insert number then print all even
                numbers between 1 to this number
                Example:
                Input: 15
                Output: 2 4 6 8 10 12 14
             
             */

            //Console.WriteLine("please, Enter Number : ");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //      //  Console.WriteLine(i);     // كل رقم في سطر لوحدو
            //        Console.Write(i + " ");        // كل الارقام علي سط واحد

            //    }
            //}

            // *********** the same solution *************


            //Console.WriteLine("please, Enter Number : ");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 2; i <= number; i+=2)
            //{
            //        Console.Write(i + " ");
            //}





            #endregion

            #region Q9
            /*
             9- Write a program that takes two integers then prints the power.
                Example:
                Input: 4 3
                Output: 64
                Hint: how to calculate 4^3 = 4 * 4 * 4 =64
             */

            //Console.WriteLine(" Please Enter number ");
            //int.TryParse(Console.ReadLine(), out int number1);

            //Console.WriteLine(" please  Enter number bower ");
            //int.TryParse(Console.ReadLine(), out int bower);

            //int result = 1;

            //if (bower == 0)
            //{
            //    result = 1; // أي رقم أس صفر = 1
            //}

            //else if (bower > 0)
            //{
            //    for (int i = 1; i <= bower; i++)
            //    {
            //        result *= number1;
            //    }
            //}

            //else 
            //{
            //    for (int i = bower; i < 0; i++)
            //    {
            //        result *= number1;
            //    }

            //    Console.WriteLine($"Result = {1 / result}");

            //}

           
            //Console.WriteLine(number1 + " ^ " + bower + " = " + result);

            #endregion

            #region Q10

            /*
             * 10- Write a program to enter marks of five subjects and calculate total,
                average and percentage.
                Example
                Input: - Enter Marks of five subjects: 95 76 58 90 89
                Output: Total marks = 408
                Average Marks = 81
                Percentage = 81
             */

            //Console.WriteLine(" Enter Marks of  Subject => 1 : ");
            //int.TryParse(Console.ReadLine(), out int subject1 );

            //Console.WriteLine(" Enter Marks of  Subject => 2 : ");
            //int.TryParse(Console.ReadLine(), out int subject2);

            //Console.WriteLine(" Enter Marks of Subject => 3 : ");

            //int.TryParse(Console.ReadLine(), out int subject3);

            //Console.WriteLine(" Enter Marks of  Subject => 4 : ");
            //int.TryParse(Console.ReadLine(), out int subject4);

            //Console.WriteLine(" Enter Marks of  Subject => 5 : ");
            //int.TryParse(Console.ReadLine(), out int subject5);

            //int total, Average, Percentage;

            //total = subject1+ subject2 + subject3 + subject4 + subject5;

            //Average = (subject1 + subject2 + subject3 + subject4 + subject5) / 5;

            //Percentage = ( total *  100 ) / 95; // => مش عارف بتتجاب ازاي 

            //Console.WriteLine(total);
            //Console.WriteLine(Average);
            //Console.WriteLine(Percentage);


            #endregion

            #region Q11
            /*
             * 11- Write a program to input the month number and print the number of days in
                that month.
                Example
                Input: Month Number: 1
                Output: Days in Month: 31
             */

            //Console.WriteLine(" Enter The Month : ");
            //int month = int.Parse(Console.ReadLine());

            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine($"Month {month} January => 31 ");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Month  {month} February => 29 ");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Month {month} March => 31 ");
            //        break;
            //    case 4:
            //        Console.WriteLine($"Month {month} April => 30 ");
            //        break;
            //    case 5:
            //        Console.WriteLine($"Month  {month} May => 31 ");
            //        break;
            //    case 6:
            //        Console.WriteLine($"Month  {month} June => 30 ");
            //        break;
            //    case 7:
            //        Console.WriteLine($"Month  {month} July => 31 ");
            //        break;
            //    case 8:
            //        Console.WriteLine($"Month  {month} August => 31 ");
            //        break;
            //    case 9:
            //        Console.WriteLine($"Month  {month} September => 30 ");
            //        break;
            //    case 10:
            //        Console.WriteLine($"Month  {month} October => 31 ");
            //        break;
            //    case 11:
            //        Console.WriteLine($"Month  {month} November => 30 ");
            //        break;
            //    case 12:
            //        Console.WriteLine($"Month  {month} December => 31 ");
            //        break;
            //}

            #endregion

            #region Q12
            /*  12- Write a program to create a Simple Calculator. */

            //////        Switch      /////////////

            //Console.WriteLine(" Enter a first Number : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter a Operation => ( + , - , * , /  ) ");
            //char operation = char.Parse(Console.ReadLine());


            //Console.WriteLine(" Enter a Second  Number : ");
            //int number2 = int.Parse(Console.ReadLine());


            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
            //        break;
            //    case '-':
            //        Console.WriteLine(number1 + " - " + number2 + " = " +( number1 - number2));
            //        break;
            //    case '*':
            //        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
            //        break;
            //  case '/':
            //        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
            //       break;
            //case '%':
            //        Console.WriteLine(number1 + " % " + number2 + " = " + (number1 % number2));
            //   break;

            //        default:
            //        Console.WriteLine(" Error , We can not value ");
            //        break;  
            //}

            /******************    if      **************/



            //Console.WriteLine(" Enter a first Number : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter a Operation => ( + , - , * , /  ) ");
            //char operation = char.Parse(Console.ReadLine());


            //Console.WriteLine(" Enter a Second  Number : ");
            //int number2 = int.Parse(Console.ReadLine());


            //if (operation == '+')
            //    Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));

            //else if (operation == '-')
            //    Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));

            //else if (operation == '*')
            //    Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));

            //else if (operation == '/')
            //    Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));

            //else if (operation == '%')
            //    Console.WriteLine(number1 + " % " + number2 + " = " + (number1 % number2));

            //else
            //    Console.WriteLine(" Operation Can not Found ");

            #endregion

            #region Q13
            /*
             * 13- Write a program to allow the user to enter a string and print the REVERSE of it                                                                        
             */

            // Console.WriteLine(" Enter a string ");
            //string message = Console.ReadLine();

            // string REVERSE = "";

            // for (int i = message.Length -1 ;  i >= 0; i--)
            // {
            //     REVERSE += message[i];
            // }

            // Console.WriteLine(" After REVERSE => " + REVERSE);



            #endregion

            #region 14
            /*
             * 13- Write a program to allow the user to enter a int and print the REVERSE of it                                                                        
             */


            //  int  عشان معرفتش اعملها ب ال  String  انا عملتها ب 


            //Console.WriteLine(" Enter a string ");
            //string message = Console.ReadLine();

            //string REVERSE = "";

            //for (int i = message.Length - 1; i >= 0; i--)
            //{
            //    REVERSE += message[i];
            //}

            //Console.WriteLine(" After REVERSE => " + REVERSE);



            #endregion


            #region Q15 

            /*
             * 15- Write a program in C# Sharp to find prime numbers within a range of
                numbers.
                Test Data :
                Input starting number of range: 1
                Input ending number of range : 50
                Expected Output :
                The prime number between 1 and 50 are :
                2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
             */




            bool flag01 , flag02;
            int Start, End, count;

            do
            {
                Console.WriteLine(" Enter Number 1 ");
                flag01 = int.TryParse(Console.ReadLine(), out Start);
                Console.WriteLine(" Enter Number 2 ");
                flag02 = int.TryParse(Console.ReadLine(), out End);
            }
            while (!(flag01 && flag02));
            for (int i = Start; i <= End; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }

                if (count == 2 && i != 1)
                    Console.WriteLine(i);
            }



            #endregion

            #region Q16
            /*
             * 16- Create a program that asks the user to input three points (x1, y1), (x2,
                y2), and (x3, y3), and determines whether these points lie on a single
                straight line.
             * 
             */

            //Console.WriteLine( " Enter  x1 : " );
            //int x1 = int.Parse( Console.ReadLine() );

            //Console.WriteLine(" Enter  y1 : ");
            //int y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Entert x2 : ");
            //int x2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter  y2 : ");
            //int y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter  x3 : ");
            //int x3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter  y3 : ");
            //int y3 = int.Parse(Console.ReadLine());


            // if ((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
            //{
            //    Console.WriteLine("Yes, the points lie on the same straight line.");
            //}
            //else
            //{
            //    Console.WriteLine(" No, the points do not lie on the same straight line.");
            //}

            #endregion

            #region Q17


            /*
             17- Within a company, the efficiency of workers is evaluated based on the
                duration required to complete a specific task. A worker's efficiency level is
                determined as follows:
                - If the worker completes the job within 2 to 3 hours, they are considered
                highly efficient.
                - If the worker takes 3 to 4 hours, they are instructed to increase their
                speed.
                - If the worker takes 4 to 5 hours, they are provided with training to
                enhance their speed.
                - If the worker takes more than 5 hours, they are required to leave the
                company.
                To calculate the efficiency of a worker, the time taken for the task is
                obtained via user input from the keyboard.
             */

            //Console.WriteLine("Enter The Time Taken for the Task ");
            //float hours = float.Parse(Console.ReadLine());


            //if (hours >= 2  && hours <=  3)
            //{
            //    Console.WriteLine("Very Good you highly efficient.");
            //}

            //else if (hours > 3 && hours <= 4)
            //{
            //    Console.WriteLine(" Good must be increase their Speed  .");
            //}

            //else if (hours > 4 && hours <= 5)
            //{
            //    Console.WriteLine("  must be they are provided with training to enhance their speed. .");
            //}

            //else if (hours > 5)
            //{
            //    Console.WriteLine(" Sorry ,  You To leave the company  .");
            //}

            //else
            //{
            //    Console.WriteLine(" invalid input , must input between 2 or 5 Hours");
            //}


            #endregion

        }
    }
}
