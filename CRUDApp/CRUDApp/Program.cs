// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static List<string> users = new List<string>();

    static void Main()
    {
        Console.WriteLine("Sistema CRUD básico");

        // Agregar usuarios
        users.Add("Luis");
        users.Add("Ana");

        // Mostrar usuarios
        ShowUsers();
    }

    static void ShowUsers()
    {
        Console.WriteLine("Lista de usuarios:");

        foreach (var user in users)
        {
            Console.WriteLine("- " + user);
        }
    }
}