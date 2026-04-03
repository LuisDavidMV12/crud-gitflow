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
        users.Add("Carlos");

        ShowUsers();

        DeleteUser("Ana");

        Console.WriteLine("\nDespués de eliminar:");
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

    static void DeleteUser(string name)
    {
        if (users.Remove(name))
        {
            Console.WriteLine("\nUsuario eliminado correctamente");
        }
        else
        {
            Console.WriteLine("\nUsuario no encontrado");
        }
    }
}