/// Homework No. 1
/// File Name: ImpossibleTriangle.cs
/// @author: Parker Verran
/// Date:  August 25, 2024
///
/// Problem Statement: Print a picture on the screen using various characters
/// 
/// 
/// Overall Plan:
/// 1) Print a picture of an impossible triangle in the console using multiple lines of text and characters
/// 2) Wait for enter key press to close the program
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject;

class MyFirstProgram
{

    static void Main(string[] args)
    {

        //print a picture of an impossible triangle using Console.WriteLine
        Console.WriteLine("                _____");
        Console.WriteLine("             /  \\    \\");
        Console.WriteLine("            /    \\    \\");
        Console.WriteLine("           /      \\    \\");
        Console.WriteLine("          /        \\    \\");
        Console.WriteLine("         /          \\    \\");
        Console.WriteLine("        /     /\\     \\    \\");
        Console.WriteLine("       /     /  \\     \\    \\");
        Console.WriteLine("      /     /   A      \\    \\");
        Console.WriteLine("     /     /   /  \\     \\    \\");
        Console.WriteLine("    /     /   /    \\     \\    \\");
        Console.WriteLine("   /     /   /      \\     \\    \\");
        Console.WriteLine("  /     /   _______________\\    \\");
        Console.WriteLine(" /     /   /                     \\");
        Console.WriteLine("/     /   /_______________________\\");
        Console.WriteLine("\\    /                            /");
        Console.WriteLine(" \\  /                            /");
        Console.WriteLine("  \\ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //Wait for user to click the enter key to stop the progam
        Console.ReadLine();
    }

}