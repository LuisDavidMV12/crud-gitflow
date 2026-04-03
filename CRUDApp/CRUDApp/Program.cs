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

        UpdateUser("Luis", "Carlos");

        Console.WriteLine("\nDespués de actualizar:");
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

    static void UpdateUser(string oldName, string newName)
    {
        int index = users.IndexOf(oldName);

        if (index != -1)
        {
            users[index] = newName;
            Console.WriteLine("\nUsuario actualizado correctamente");
        }
        else
        {
            Console.WriteLine("\nUsuario no encontrado");
        }
    }
}