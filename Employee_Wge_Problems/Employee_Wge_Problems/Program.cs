﻿// See https://aka.ms/new-console-template for more information

int fullTime = 1, PartTime = 2, EmpRatePerHour = 20, empHrs = 0, empWage = 0;
    Random randobj = new Random();
    int checkPresent = randobj.Next(0, 3);
    Console.WriteLine("Random number=" + checkPresent);
    if(checkPresent == fullTime)
    {
        empHrs = 8;
        Console.WriteLine("Employee Is Present");
    }
    else if(checkPresent == PartTime)
    {
        empHrs = 4;
        Console.WriteLine("Employee is part time");
    }
    else
    {
        empHrs = 0;
        Console.WriteLine("Employee Is Absent");
    }
    empWage = empHrs * EmpRatePerHour;
    Console.WriteLine("Employee Wage:" + empWage);
