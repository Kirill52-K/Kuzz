using kuz15.Models;
using System;
using System.Collections.Generic;

namespace TodolistApp.Managers
{
    internal class TodolistManager
    {
        private List<TodoItem> _todolist = new List<TodoItem>();
        private int _nextId;

        // Конструктор менеджера
        public TodolistManager()
        {
            // Инициализируем тестовыми данными при создании менеджера
            _todolist.Add(new TodoItem(1, "Buy groceries"));
            _todolist.Add(new TodoItem(2, "Read a book"));
            _todolist.Add(new TodoItem(3, "Go for a walk"));
        }

        // Метод для отображения списка дел в консоли
        public void DisplayTodolist()
        {
            Console.WriteLine("\n--- Your To-Do List ---");
            if (_todolist.Count == 0)
            {
                Console.WriteLine("Your list is empty!");
            }
            else
            {
                foreach (var item in _todolist)
                {
                    Console.WriteLine($"{item.Id}. {item.GetStatusDisplay()} {item.Description}");
                }
                Console.WriteLine("---");
            }
        }
        // Метод для добавления новой задачи
        public void AddTask(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                _todolist.Add(new TodoItem(_nextId++, description));
                Console.WriteLine("Task added successfully!");
            }
            else
            {
                Console.WriteLine("Task description cannot be empty.");
            }
        }
        // Метод для переключения статуса выполнения задачи
        public bool ToggleTaskCompletion(int taskId)
        {
            var taskToToggle = _todolist.FirstOrDefault(t => t.Id == taskId);
            if (taskToToggle != null)
            {
                taskToToggle.IsCompleted = !taskToToggle.IsCompleted;
                Console.WriteLine($"Task {taskId} completion status updated.");
                return true;
            }
            else
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return false;
            }
        }
    }
} 
