﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBGame
{
    class Program
    {
        static public Room currentRoom;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("How do you want to be adressed?");
           
            string pronoun = Console.ReadLine();
            Character user = new Character(username,pronoun);
            Console.WriteLine("This is "+ user.name+", doesn't " +user.pronoun +" look fabulous today?");

            Room room0 = new Room("It is a 30 square meter room with red walls.");
            Room room1 = new Room("It is a 40 square meter room with green walls.");
            Room room2 = new Room("It is a 50 square meter room with blue walls.");
            room0.neighborrooms.Add("hall", room2);

            currentRoom = room0;
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                Getcommand(command);
                
            }
            

        }
        static void Getcommand(string[] args)
        {
            if (args[0]== "exit") {
                Environment.Exit(0);
            }
            else if (!currentRoom.GetCommand(args))
            {
                Console.WriteLine("This is not a valid command! Try again.");
            }

        }
    }
    
}
