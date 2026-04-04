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
        users.Add("Ana");

        ShowUsers();

        Login("Luis");
    }

    static void ShowUsers()
    {
        Console.WriteLine("Lista de usuarios:");

        foreach (var user in users)
        {
            Console.WriteLine("- " + user);
        }
    }

    static void Login(string name)
    {
        if (users.Contains(name))
        {
            Console.WriteLine("\nLogin exitoso: " + name);
        }
        else
        {
            Console.WriteLine("\nUsuario no encontrado");
        }
    }
}