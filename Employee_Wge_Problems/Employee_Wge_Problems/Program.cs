﻿// See https://aka.ms/new-console-template for more information

    int fullTime = 1;
    Random randobj = new Random();
    int checkPresent = randobj.Next(0, 2);
    Console.WriteLine("Random number=" + checkPresent);
    if(checkPresent == fullTime)
    {
        Console.WriteLine("Employee Is Present");
    }
    else
    {
        Console.WriteLine("Employee Is Absent");
    }

