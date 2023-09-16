﻿using System;
using System.IO;

namespace Task_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //Quz program
            Console.WriteLine("Input 1 to create new quiz or input 2 to take a quiz");
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("input quiz name");
                    var name = Console.ReadLine();
                    var path = @"../../QuizFiles/" + name + ".txt";
                    var quiz = new Quiz(name, path);
                    quiz.CreateQuiz(path);
                    break;
                case 2:
                    Console.WriteLine("choose quiz");
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }
    }
}