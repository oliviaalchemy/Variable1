using System;

namespace Variable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;         //these are both different ways to do the same thing
            Console.WriteLine("There once was a man named " + characterName); 
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";     // putting character name will only change it from here onwards
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
        }
    }

