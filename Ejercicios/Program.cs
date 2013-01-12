//#define start Stopwatch sw = new Stopwatch(); sw.Start();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Reflection;

namespace Ejercicios
{
    class Program
    {
        /// <summary>
        /// Calls the "Run" method inside the class specified in name
        /// </summary>
        /// <param name="name">The name of the exersise which will be run</param>
        static void RunExersise(string name)
        {
            // Get the current assembly
            Assembly asm = Assembly.GetExecutingAssembly();
            // Get all the classes in the assembly
            foreach (Type type in asm.GetTypes())
            {
                // If the name match
                if (type.Name.ToLower() == name.ToLower())
                {
                    // If it has a member called "Run"
                    if (type.GetMembers().Where(m => m.Name == "Run") != null)
                    {
                        // Create an instance of the class
                        Object obj = type.InvokeMember(null,
                                                    BindingFlags.DeclaredOnly |
                                                    BindingFlags.Public | BindingFlags.NonPublic |
                                                    BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                        // Call the "Run" member
                        type.InvokeMember("Run",
                                        BindingFlags.DeclaredOnly |
                                        BindingFlags.Public | BindingFlags.NonPublic |
                                        BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);
                        // Profit
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Exercises from: http://www.dreamincode.net/forums/topic/78802-martyr2s-mega-project-ideas-list/
            Console.WriteLine("Escriba el nombre de la clase que quiere correr \n");
            string x;
            while((x = Console.ReadLine()) != "exit")
            {
                RunExersise(x);
                //Scheduler.ScheduleEvent(null, null, 0);
                //Console.ReadLine();
            }
        }
    }
}
