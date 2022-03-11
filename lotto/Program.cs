// See https://aka.ms/new-console-template for more information


using System;

namespace Lotto{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lottos = {0, 0, 0, 0, 0, 0};
            int[] winnums = {38, 19, 20, 40, 15, 25}; 
            Solution sol = new Solution();
            sol.solution(lottos, winnums);
            System.Console.WriteLine("hello lotto example");
        }
    }
}