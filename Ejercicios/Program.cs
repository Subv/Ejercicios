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
        /// <param name="name">The name of the exercise which will be run</param>
        static void RunExercise(string name)
        {
            bool runall = name == "runall";
            Stopwatch total = new Stopwatch();
            total.Start();
            // Get the current assembly
            Assembly asm = Assembly.GetExecutingAssembly();
            // Get all the classes in the assembly
            foreach (Type type in asm.GetTypes())
            {
                // If the name match
                if ((runall && type.Name.ToLower().Contains("euler") && !type.IsSubclassOf(typeof(System.Windows.Forms.Form))) || (type.Name.ToLower() == name.ToLower()))
                {
                    // If it has a member called "Run"
                    if (type.GetMembers().Where(m => m.Name == "Run") != null)
                    {
                        Console.WriteLine("Running {0}", type.Name);
                        // Create an instance of the class
                        Object obj = type.InvokeMember(null,
                                                    BindingFlags.DeclaredOnly |
                                                    BindingFlags.Public | BindingFlags.NonPublic |
                                                    BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
                        Stopwatch watch = new Stopwatch();
                        watch.Start();
                        // Call the "Run" member
                        type.InvokeMember("Run",
                                        BindingFlags.DeclaredOnly |
                                        BindingFlags.Public | BindingFlags.NonPublic |
                                        BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);
                        watch.Stop();
                        total.Stop();
                        // Report the elapsed time
                        Console.WriteLine("Finished working, took {0} ns ({1} ms) to invoke and execute the Run method, and {2} ns ({3} ms) total.\n", watch.Elapsed.TotalMilliseconds * 1000000, watch.ElapsedMilliseconds, watch.Elapsed.TotalMilliseconds * 1000000, watch.ElapsedMilliseconds);
                        if (!runall)
                            return;
                    }
                }
            }
            if (!runall)
                Console.WriteLine("Error: Exercise {0} not found", name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Type in the class name that you want to run.");
            string x;
            while((x = Console.ReadLine()) != "exit")
                RunExercise(x);
        }
    }
}
