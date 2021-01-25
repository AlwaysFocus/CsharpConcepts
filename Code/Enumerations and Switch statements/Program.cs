using System;
using System.Collections.Generic;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ToDo> myTodos = new List<ToDo>()
            {
                new ToDo{Description = "Task 1", EstimatedHours = 5, Status = Status.Complete},
                new ToDo{Description = "Task 2", EstimatedHours = 5, Status = Status.NotStarted},
                new ToDo{Description = "Task 3", EstimatedHours = 5, Status = Status.Deleted},
                new ToDo{Description = "Task 4", EstimatedHours = 5, Status = Status.InProgress},
                new ToDo{Description = "Task 5", EstimatedHours = 5, Status = Status.InProgress},
                new ToDo{Description = "Task 6", EstimatedHours = 5, Status = Status.OnHold},
                new ToDo{Description = "Task 7", EstimatedHours = 5, Status = Status.Complete},
                new ToDo{Description = "Task 8", EstimatedHours = 5, Status = Status.Complete},
                new ToDo{Description = "Task 9", EstimatedHours = 5, Status = Status.Complete},
                new ToDo{Description = "Task 10", EstimatedHours = 5, Status = Status.Complete},
            };


            PrintAssessment(myTodos);

            // This is access the ConsoleColor enum
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.ReadLine();
        }

        private static void PrintAssessment(List<ToDo> todos)
        {
            foreach (var todo in todos)
            {

                // Using a switch statement
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.Complete:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        break;
                }

                Console.WriteLine(todo.Description);


            }
        }
    }

    class ToDo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }


    // Enumerations are used to restrict possible values that can be used
    // for a property of variable. When these values are stored outside of
    // your program, they will have a number associated with their index
    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Complete,
        Deleted
    }
}
