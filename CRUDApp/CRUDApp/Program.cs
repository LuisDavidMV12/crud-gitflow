// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static List<string> users = new List<string>();

    static void Main()
    {
        Console.WriteLine("Sistema CRUD básico");

        users.Add("Luis");

        foreach (var user in users)
        {
            Console.WriteLine("Usuario: " + user);
        }
    }
}