using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_2_Challenge_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Week 2 Challenge Labs");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*1. Write a C# Sharp program to read temperature in fahrenheit and 
             * display a suitable message according to temperature state below :
            Temp 0< 10 then Freezing weather
            Temp 11-20 then Very Cold weather
            Temp 21-35 then Cold weather
            Temp 36-50 then Normal in Weather
            Temp 51-65 then Its Hot
            Temp 66-80 then Its Very Hot

            Test Data :
            67
            Expected Output :
            Its very hot.
            */
            Pt1StartPoint:

            Console.WriteLine("\nI will tell you the weather condition!");
            Console.Write("Enter the tempeture: ");
            int temp = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            if (0 <= temp && temp <= 10) { Console.WriteLine("\nFreezing weather"); }
            if (11 <= temp && temp <= 20) { Console.WriteLine("\nVery Cold weather"); }
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (21 <= temp && temp <= 35) { Console.WriteLine("\nCold weather"); }
            Console.ForegroundColor = ConsoleColor.White;
            if (36 <= temp && temp <= 50) { Console.WriteLine("\nNormal in Weather"); }
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (51 <= temp && temp <= 65) { Console.WriteLine("\nIts Hot"); }
            Console.ForegroundColor = ConsoleColor.Red;
            if (61 <= temp && temp <= 80) { Console.WriteLine("\nIts Very Hot"); }
            Console.ForegroundColor = ConsoleColor.White;


            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto Pt1StartPoint;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();

            //PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 2---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*
            2. Write a program in C# Sharp to create and copy the file to another name and display the content.
            You may use any file names and any content that you like .
            Purpose is to use create and copy functionality along with read file.
            Expected Output :
            Here is the content of the file mytest.txt :
            Hello and Welcome
            It is the first content
            of the text file mytest.txt

            The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.
            Here is the content of the file mynewtest.txt :
            Hello and Welcome
            It is the first content
            of the text file mytest.txt
            */

            // declare files and path
            string originalFile = "mytest.txt";
            string newFile = "mynewtest.txt";
            string sourceFolder = @"C:\MSSA\Files\";

            // create and write inside file
            File.AppendAllText(sourceFolder + originalFile, "Hello and Welcome \nIt is the first content \nof the text file mytest.txt\n");

            //makes a copy of orginalFile and puts contents in sourceFolder + newFile
            File.Copy(sourceFolder + originalFile, sourceFolder + newFile, true);

            // console print
            Console.WriteLine($"The file {originalFile} successfully copied to the name {newFile} in the same directory.");

            // 'mytest.txt' file header
            Console.WriteLine($"\n{originalFile} File Contents:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            // reading path (C:\MSSA\Files\mytest.txt)
            using (StreamReader reader = new StreamReader(sourceFolder + originalFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // 'mynewtest.txt' file header
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{newFile} File Contents:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            // reading path (C:\MSSA\Files\mytest.txt)
            using (StreamReader reader = new StreamReader(sourceFolder + newFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }



            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();

            //PART 3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 3---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*
            3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
            */

            Console.WriteLine("To Log in, enter the correct Username and Password:");

            //declare username and password
            const string correctUsername = "Admin";
            const string correctPassword = "PCAD11";

            // declare attempt and seting to 0
            int attempt = 0;
            int maxAttempts = 3;


            while (attempt < 3)
            {
                Console.Write("Enter Username: ");
                string userInputUsername = Console.ReadLine();

                Console.Write("Enter Password: ");
                string userInputPassword = Console.ReadLine();

                if (userInputUsername != correctUsername || userInputPassword != correctPassword)
                {
                    attempt++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou have entered either your username or password wrong. Please try again!");
                    Console.WriteLine($"You have {maxAttempts - attempt} attempts left.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nYou have successfully logged in!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }

            if (attempt == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nToo many failed attempts. You have been locked out.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();

            //PART 4
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 4---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("I can make an upside down right triangle!");

            /*
            4. Write a C# Sharp program that takes a number and a width also a number, 
            as input and then displays a triangle of that width, using that number.
            Test Data
            Enter a number: 6
            Enter the desired width: 6
            Expected Output:
            666666
            66666
            6666
            666
            66
            6
            */

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine();// spacer

            for (int i = width; i >= 0; i--) // i = 6, stop when i = 0, i decreases by 1
            {
                for (int j = 1; j <= i; j++) // j = 1, stop when j >= i, j increase by 1
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }

            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();

            //PART 5
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 5---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*
            5. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total,
            percentage and division. You may create a structure for the student.
            Test Data :
            Input the Roll Number of the student :784
            Input the Name of the Student :James
            Input the marks of Physics, Chemistry and Computer Application : 70 80 90
            Expected Output :
            Roll No : 784
            Name of Student : James
            Marks in Physics : 70
            Marks in Chemistry : 80
            Marks in Computer Application : 90
            Total Marks = 240
            Percentage = 80.00
            Division = First
            */

            Pt5StartPoint: 

            // roll number
            Console.Write("\nInput the Roll Number of the student: ");
            int rollNumber = int.Parse(Console.ReadLine());

            // student name
            Console.Write("Input the Name of the Student: ");
            string studentName = Console.ReadLine();

            // marks
            Console.Write("Input the marks of Physics, Chemistry, and Computer Application: ");
            string[] marks = Console.ReadLine().Split(' ');
            float physGrade = float.Parse(marks[0]);
            float chemGrade = float.Parse(marks[1]);
            float compGrade = float.Parse(marks[2]);
            
            // calcualte percentage
            float percentage = (physGrade + chemGrade + compGrade) / 3;

            //division
            string division;
            if (percentage >= 60) {division = "First";}
            else if (percentage >= 50) { division = "Second";}
            else if (percentage >= 40) { division = "Third"; }
            else {division = "Fail";}

            // console print
            Console.WriteLine($"\n\nRoll No: {rollNumber}" +
                $"\nName of Student: {studentName}" +
                $"\nMarks in Physics: {physGrade}" +
                $"\nMarks in Chemistry: {chemGrade}" +
                $"\nMarks in Computer Application: {compGrade}" +
                $"\nTotal Marks = {physGrade + chemGrade + compGrade}" +
                $"\nPercentage = {(physGrade + chemGrade + compGrade)/3:00.00}" +
                $"\nDivision: {division}");

            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto Pt5StartPoint;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");

            Console.ReadKey();
        }
    }
}
