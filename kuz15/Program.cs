using System;
using TodolistApp.Managers;

namespace TodolistApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enhanced To - Do List!");

            // Создаем экземпляр менеджера списка дел
            var todoManager = new TodolistManager();

            // Теперь вызываем методы через экземпляр менеджера
            todoManager.DisplayTodolist();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
