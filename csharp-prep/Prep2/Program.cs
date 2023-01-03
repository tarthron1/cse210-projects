using System;

class Program
{
    static void Main(string[] args)
    {   //Core Requirement 1 & 3
        Console.WriteLine("What is your grade perctentage?");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "";
        if (grade >= 90){
            letterGrade = "A";
        }else if (grade >= 80){
            letterGrade = "B";
        }else if (grade >=70){
            letterGrade = "C";
        }else if (grade >= 60){
            letterGrade = "D";
        }else  {
            letterGrade = "F";
        }

        //Strech Challange 1
        string letterGradeSign = "";
        if (grade % 10 >= 7){
            letterGradeSign ="+";
        }else if (grade % 10 < 3 )  {
            letterGradeSign = "-";
        }

        //Streach Challange 2 & 3
        if ((letterGrade == "A" && letterGradeSign == "+")|| (letterGrade == "F")){
            letterGradeSign = "";
        }
        Console.WriteLine($"Your letter grade is {letterGradeSign}{letterGrade}");
        
        //Core Requirement 2
        if (grade >= 70){
            Console.WriteLine("Congradulations you passed the course!");
        } else {
            Console.WriteLine("You may not have passed this time but never give up!");
        }
    }
}