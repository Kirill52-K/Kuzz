using System;
using TodolistApp.Managers;

namespace TodolistApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Personal To-Do Manager");

            // Создаем экземпляр менеджера списка дел
            var todoManager = new TodolistManager();

            // Теперь вызываем методы через экземпляр менеджера
            todoManager.DisplayTodolist();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
