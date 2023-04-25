// See https://aka.ms/new-console-template for more information
// Starter to Intermediate C# Lessons
// most install recent .net SKS and put entire dotnet folder as a path into enivorment variables
// to start projects like this go to terminal
// input -> dotnet new console -o {name for project}
// Cd to project name
// input -> dotnet build
// to run input into terminal -> dotnet run {str name} {int age} {str dog-name} {int num1} {int num2} {int dog-age} {str dog-breed}
using System;

// public meaning --> public is an access modifier that determines the visibility of a class, method, property, or other members. When a member is declared as public, it can be accessed from any code within the same project or other projects that reference it. Other access modifiers in C# include private, protected, and internal.

// public void meaning --> public void is a method declaration that specifies the method is public (accessible from anywhere) and has a return type of void. A void return type means that the method does not return any value.

// static void Main --> static void Main is the entry point of a C# console application. It is a method that has a return type of void and is marked as static. The static keyword indicates that the method belongs to the class itself, rather than an instance of the class, so it can be called without creating an object of the class. 
// In C# console applications, the Main method is called when the program starts, and it serves as the starting point for the execution of your code. You can use different method signatures for the Main method, such as accepting command-line arguments.

// covered topics in order
/*
Basics (Hello World, data types, variables, and basic operators)................| Lines 55-68
Control structures (if, else, while, for, switch, etc.).........................| Lines 72-123
Arrays..........................................................................| Lines 117-123
Classes and Objects.............................................................| Lines 138-180
Access Modifiers (Public, Private, Protected, Internal, Etc.)...................| Lines 165-169
Properties and Auto-Properties..................................................| Lines 149-149
Inheritance basics..............................................................| Lines 182-219
Interfaces basics...............................................................| Lines 221-247
Exception Handling..............................................................| Lines 249-273
Inheritance advanced............................................................| Lines 275-315
Method overriding...............................................................| Lines 317-357
Interfaces Advanced.............................................................| Lines 359-386
Polymorphism....................................................................| Lines 388-407
Generics........................................................................| Lines 409-449
Events and Delegates............................................................| Lines 451-491
LINQ............................................................................| Lines 493-513
Asyncronous Programming.........................................................| Lines 515-538
Reflection......................................................................| Lines 540-557
Attributes......................................................................| Lines 559-588
Dynamic Types...................................................................| Lines 590-600
Task Parallel Library (TPL).....................................................| Lines 602-621
Regular Expressions.............................................................| Lines 625-685
File I/O........................................................................| Lines 687-761
Exception Handling Best Practices (Labeled -> (Exception Handling Advanced))....| Lines 763-848
*/
namespace HelloWorld
{
    //Methods Methods are blocks of code that can be defined and called by name. They can take input parameters and return a value.
    class Program 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.ReadLine();

            //variables

            int age = 25;
            float height = 1.75f;
            double pi = 3.141592653589793;
            char letter = 'A';
            string message = "Hello, World!";
            bool isActive = true;

            int a = 10;
            int b = 3;
            int sum = a + b;         // 13
            int difference = a - b;  // 7
            int product = a * b;     // 30
            int quotient = a / b;    // 3
            int remainder = a % b;   // 1
            
            // for loop with an IF, Else if, else

            for (int i = 0; i < 14; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(age);
                    //Console.ReadLine();
                }
                else if (i == 1)
                {
                    Console.WriteLine(height);
                    //Console.ReadLine();
                }
                else if (i == 14)
                {
                    //does't reach 14 unless >= <= ==
                    Console.WriteLine("is here");
                    //Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("empty");
                    //Console.ReadLine();
                }


            }
            
            // while loop
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine(counter);
                //Console.ReadLine(); --> makes it so you have to hit enter so see each line disable for automation
                counter++;
            }

            // Do-While
            int count = 0;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count < 5);

            //Arrays: 
            int[] numbers = new int[5] {1,2,3,4,5};
            Console.WriteLine(numbers[0]); // Calling just numbers we get System.Int32[] so to print it we would use a for loop or an for each loop - see for each below

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //goes out of this class to ProjectAdvC into ProgramB and runs SecondMethod with args being passed in
            // args --> args is a parameter name often used in the Main method of a C# console application. It stands for "arguments" and represents an array of strings that holds the command-line arguments passed to the application when it is executed. Each element of the args array corresponds to a separate command-line argument.
            ProjectAdvC.ProgramB.SecondMethod(args);
            ProjectAdvD.ProgramD.ThirdMethod(args);
            ProjectAdvE.ProgramE.FourthImpl(args);
            ProjectAdvF.FifthImpl(args);
            ProjectAdvG.SixthImpl(args);
            ProjectAdvH.SeventhImpl(args);
        }
        

        // Moving onto Advanced topics

        // Classes and objects

        //In C#, classes are used to define custom data types, and objects are instances of those classes. A class can have properties, methods, and constructors.

        public class ProjectAdvC
        {
            //added a Higher Up class (ProjectAdvC) to wrap these classes up to be used on line 159
            //made all classes public for it to work or security would not allow it
            public class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }

                public Person(string name, int age)
                {
                    Name = name;
                    Age = age;
                }

                public void Greet()
                {
                    Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
                }
            }

            public class ProgramB
            {
                // changed this to public static void to work properly
                // public --> This is an access modifier that indicates the method can be accessed from any code within the same project or other projects that reference it. It defines the visibility of the method.
                // static --> This modifier indicates that the method belongs to the class itself, rather than an instance of the class. As a result, you can call the method without creating an object of the class. Static methods can only access other static members of the same class and cannot access instance members.
                // void -->  This is the return type of the method, which means that the method does not return any value.
                // public static void meaning --> When a method is declared as public static void, it means that the method can be called from any code that has access to the class, it belongs to the class itself (not an instance), and it does not return any value.
                // we then can call this all the way up to line 159
                public static void SecondMethod(string[] args)
                {
                    string name = args[0];
                    int age = int.Parse(args[1]);
                    Person person = new Person(name, age); //we can switch this out with args[0] and args[1] so we can input are own stuff by running say dotnet run Brody 34 and it'll output Hello, my name is Brody and I am 34 years old.
                    person.Greet(); // Output: "Hello, my name is Alice and I am 30 years old."
                }
                
            }
        }

        // Inheritance
        // Inheritance allows a class to inherit properties and methods from a base class. This helps to create a hierarchy of related classes and promote code reuse.

        public class ProjectAdvD
        {
            public class Animal
            {
                public string? Name { get; set; } //{ get; set; } is an example of auto-implemented properties in C#. They are a shorthand for defining a property with a backing field. The get accessor is used to retrieve the value of the property, while the set accessor is used to assign a new value to the property.

                //To make the Name property nullable, you can use the nullable reference types feature introduced in C# 8.0. To enable this feature, you need to add the following line to your project file (.csproj): <Nullable>enable</Nullable>
                // Then, you can use the ? modifier to make the Name property nullable: public string? Name { get; set; }

                public void MakeSound()
                {
                    Console.WriteLine($"{Name} makes a sound");
                }
            }

            class Dog : Animal
            {
                public void Bark()
                {
                    Console.WriteLine($"{Name} barks");
                }
            }

            public class ProgramD
            {
                public static void ThirdMethod(string[] args)
                {
                    string NameTM = args[2];
                    Dog dog = new Dog();
                    dog.Name = NameTM;
                    dog.MakeSound();
                    dog.Bark();
                }
            }
        }

        // Interfaces
        // Interfaces define a contract that classes can implement. They declare methods and properties without providing an implementation. Classes that implement an interface must provide an implementation for all its members.

        public class ProjectAdvE
        {
            interface IFlyable
            {
                void Fly();
            }

            public class Bird: IFlyable
            {
                public void Fly()
                {
                    Console.WriteLine("The bird flies");
                }
            }

            public class ProgramE
            {
                public static void FourthImpl(string[] args)
                {
                    Bird bird = new Bird();
                    bird.Fly();
                }
            }
        }

        // Exception Handling:
        // Error handling is an important aspect of programming. In C#, you can handle exceptions using try-catch blocks.

        public class ProjectAdvF
        {
            public static void FifthImpl(string[] args)
            {
                try
                {   
                    int numone = int.Parse(args[3]);
                    int numtwo = int.Parse(args[4]);
                    int result = Divide(numone, numtwo);
                    Console.WriteLine(result);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide by zero." + ex.Message);
                }
            }

            public static int Divide(int a, int b)
            {
                return a / b;
            }
        }

        //Inheritance Advanced
        //Inheritance is a way to create a new class that is a modified version of an existing class. The new class is called the derived class, and the existing class is the base class. The derived class inherits the members (properties, methods, fields, etc.) of the base class, and can also have additional members.

        public class ProjectAdvG
        {
            public class Animal
            {
                public string? Name { get; set; }
                public int? Age { get; set; }

                public void MakeSound()
                {
                    Console.WriteLine("The animal makes a sound.");
                    Console.WriteLine($"{Name} is {Age}");
                }
            }

            public class Dog : Animal
            {
                public string? Breed { get; set; }

                public void Bark()
                {
                    Console.WriteLine($"The {Breed} barks.");
                }
            }

            public static void SixthImpl(string[] args)
            {
                string NameTMSI = args[2];
                int DogAge = int.Parse(args[5]);
                string BreedTMSI = args[6];
                Dog myDog = new Dog();
                myDog.Name = NameTMSI;
                myDog.Age = DogAge;
                myDog.Breed = BreedTMSI;
                myDog.MakeSound();
                myDog.Bark();
            }

        }

        //Method Overriding
        //In some cases, you might want to modify the behavior of a method in the derived class. You can do this by overriding the method. To override a method, you need to use the override keyword in the derived class and the virtual keyword in the base class.

        public class ProjectAdvH
        {
            public class Animal
            {
                public string Name { get; set; }
                public int Age { get; set; }

                public virtual void MakeSound()
                {
                    Console.WriteLine("The animal makes a sound.");
                }
            }

            public class Dog : Animal
            {
                public string Breed { get; set; }

                public override void MakeSound()
                {
                    Console.WriteLine("The dog barks.");
                }
            }

            //In this example, the MakeSound method in the Animal class is marked as virtual, which means it can be overridden by derived classes. In the Dog class, the MakeSound method is marked as override, which means it will replace the base class implementation.

            public static void SeventhImpl(string[] args)
            {
                string NameTMSI = args[2];
                int DogAge = int.Parse(args[5]);
                string BreedTMSI = args[6];
                Dog myDog = new Dog();
                myDog.Name = NameTMSI;
                myDog.Age = DogAge;
                myDog.Breed = BreedTMSI;
                myDog.MakeSound();
                myDog.Bark();
            }
        }

        // Interfaces Advanced
        // An interface is a contract that defines a set of properties and methods that a class must implement. Interfaces allow you to define a common set of behaviors across multiple classes, without specifying how those behaviors are implemented.

        public class InterfaceLesson
        {
            public interface IFlyable
            {
                void Fly();
            }

            //A class can implement an interface using the : symbol:

            public class Bird : IFlyable
            {
                public void Fly()
                {
                    Console.WriteLine("The Bird Flies")
                }
            }

            // You can implement multiple interfaces by separating them with a comma:

            public class Drone : IFlyable, ICamera
            {
                // empty
            }

        }

        // Polymorphism
        // Polymorphism is a concept that allows objects of different classes to be treated as objects of a common superclass or interface. This enables you to write more flexible and reusable code. In C#, polymorphism is mainly achieved through inheritance and interfaces.

        public class PolymorphismLesson
        {
            public void MakeFly(IFlyable flyableObject)
            {
                flyableObject.Fly();
            }

            // This method takes an object that implements the IFlyable interface and calls the Fly method on it. You can pass any object that implements this interface, regardless of its class:
            public class PolyExample
            {
                Bird bird = new Bird();
                Drone drone = new Drone();

                MakeFly(bird); // Output: "The bird flies."
                MakeFly(drone); // Output: "The drone flies."
            }
        }

        //Generics
        //Generics allow you to create classes, interfaces, and methods that can work with different types while maintaining type safety. This can help you write more reusable and flexible code.

        //For example, you can create a generic class that can store a pair of values of any type:
        public class GenericsLesson
        {
            public class Pair<T1, T2>
            {
                public T1 First { get; set; }
                public T2 Second { get; set; }

                public Pair(T1 first, T2 second)
                {
                    First = first;
                    Second = second;
                }
            }

            //Here, T1 and T2 are type parameters that represent the types of the two values. You can create instances of the Pair class with different types:
            Pair<int, string> pair1 = new Pair<int, string>(1, "one");
            Pair<string, bool> pair2 = new Pair<string, bool>("key", true);

            //You can also create generic methods, interfaces, and delegates. For example, here's a generic method to swap two values:
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }

            //You can call this method with different types:

            int x = 1;
            int y = 2;
            Swap(ref x, ref y);

            string str1 = "hello";
            string str2 = "world";
            Swap(ref str1, ref str2);

        }

        // Events and Delegates
        // Events enable a class to notify other classes when something happens, like a state change or user action. Events are based on delegates, which are type-safe function pointers. Delegates define the signature of the methods that can be associated with them.

        //Here's an example of a delegate and an event:

        public class EventsNDelegatesLesson
        {
            public delegate void MyEventHandler(string message);

            public class EventPublisher
            {
                public event MyEventHandler MyEvent;

                public void RaiseEvent(string message)
                {
                    MyEvent?.Invoke(message);
                }
            }

            //In this example, the MyEventHandler delegate defines the signature of the methods that can be associated with the MyEvent event. The EventPublisher class has an event named MyEvent that other classes can subscribe to.

            //To subscribe to an event, you can use the += operator:

            public class EventSubscriber
            {
                public void OnMyEvent(string message)
                {
                    Console.WriteLine("Received event: " + message);
                }
            }

            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            publisher.MyEvent += subscriber.OnMyEvent;

            //Now, when the event is raised, the OnMyEvent method of the EventSubscriber class will be called:

            publisher.RaiseEvent("Hello, World!"); // Output: "Received event: Hello, World!"

        }

        // LINQ (Language Integrated Query)
        // LINQ is a set of features that allows you to perform powerful, expressive queries on collections of data in a type-safe manner. LINQ can be used with various data sources, such as arrays, lists, XML, and databases.

        //Here's an example of a simple LINQ query:

        public class LINQLesson
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbers = from number in numbers
                            where number % 2 == 0
                            select number;

            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            //This query selects all even numbers from the numbers array. LINQ provides a rich set of query operators for filtering, sorting, projecting, and joining data.

        }

        //Asynchronous Programming with async/await
        //Asynchronous programming helps you write more responsive and efficient applications by allowing you to perform time-consuming operations without blocking the main thread. In C#, you can use the async and await keywords to write asynchronous code.

        //Here's an example of an asynchronous method:

        public class AsynchronousLesson
        {
            public async Task<int> GetResultAsync()
            {
                await Task.Delay(1000); // Simulate a time-consuming operation
                return 42;
            }

            //This method returns a Task<int> that represents the ongoing operation. The async keyword indicates that the method contains asynchronous code, and the await keyword is used to wait for the operation to complete without blocking the main thread.

            //To call an asynchronous method, you can use the await keyword:
            public async Task UseResultAsync()
            {
                int result = await GetResultAsync();
                Console.WriteLine("Result: " + result);
            }

            //When you call an asynchronous method, the control is returned to the caller immediately, allowing the application to continue running other tasks while waiting for the operation to complete.
        }

        //Reflection 
        //Reflection is a feature in .NET that enables you to inspect and interact with the metadata of types, objects, and assemblies at runtime. With reflection, you can create instances of types, invoke methods, get or set property values, and more, all without knowing the types at compile time.
        //Here's an example of using reflection to create an instance of a class and invoke a method:

        public class ReflectionLesson
        {
            // input at top using System.Reflection;

            Type type = typeof(MyClass);
            object instance = Activator.CreateInstance(type);

            MethodInfo methodInfo = type.GetMethod("MyMethod");
            methodInfo.Invoke(instance, null);

            //In this example, the Type class is used to get information about the MyClass type. The Activator.CreateInstance method is used to create a new instance of the class, and the GetMethod and Invoke methods are used to call the MyMethod method on the instance.

            //Keep in mind that reflection can be slow and insecure if misused, so use it judiciously.
        }

        //Attributes
        //Attributes are a way to add metadata to your code elements, such as classes, methods, properties, and fields. You can use attributes to provide additional information or behavior to your code.
        //Here's an example of a custom attribute:

        public class AttributesLesson
        {
            public class MyAttribute : Attribute
            {
                public string Description { get; set; }

                public MyAttribute(string description)
                {
                    Description = description;
                }
            }

            //You can apply this attribute to a class or method like this:

            [MyAttribute("This is a custom attribute.")]
            public class MyClass
            {
                // ...
            }

            //You can use reflection to read the attributes of a code element at runtime:

            MyAttribute attribute = (MyAttribute)Attribute.GetCustomAttribute(typeof(MyClass), typeof(MyAttribute));
            Console.WriteLine(attribute.Description);

        }

        //Dynamic Types
        //The dynamic keyword in C# allows you to work with objects whose types are not known at compile time. When you use the dynamic keyword, the type checking is deferred until runtime, which can lead to more flexible code.
        //Here's an example of using the dynamic keyword:

        public class DynamicTypesLesson
        {
            dynamic obj = new MyClass();
            obj.MyMethod(); // No compile-time type checking

            //In this example, the obj variable is of type dynamic, so you can call the MyMethod method without knowing the type of obj at compile time. If the method doesn't exist, you'll get a runtime exception.
        }

        //Task Parallel Library (TPL)
        //The Task Parallel Library (TPL) is a set of features in .NET that simplifies parallel programming and helps you write more efficient, concurrent code. TPL introduces the Task class, which represents an asynchronous operation that can be awaited using the await keyword.
        //Here's an example of using TPL to run two tasks in parallel:

        public class TPLLesson
        {
            Task task1 = Task.Run(() =>
            {
                // Do some work
            });

            Task task2 = Task.Run(() =>
            {
                // Do some other work
            });

            await Task.WhenAll(task1, task2);

            //In this example, two tasks are started using the Task.Run method, and the Task.WhenAll method is used to wait for both tasks to complete. The TPL also provides other features, such as parallel loops, data parallelism, and the Parallel class.
        }

        //ADVANCED CONCEPTS

        //Regular Expressions
        //A regular expression (regex) is a pattern that describes a set of strings. C# provides support for regular expressions through the System.Text.RegularExpressions namespace. The Regex class is the main class you'll work with when using regular expressions.
        //Here's a simple example of using a regular expression to validate an email address:

        public class RegexLesson
        {
            //at top
            //using System;
            //using System.Text.RegularExpressions;
            //at top

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string email = "example@example.com";

            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Valid email address");
            }
            else
            {
                Console.WriteLine("Invalid email address");
            }

            //In this example, a pattern is defined to match valid email addresses. The Regex.IsMatch() method checks if the provided string (email address) matches the pattern.

            //Capturing Groups and Named Groups
            //You can use parentheses to define capturing groups within your regular expression pattern. These groups can then be accessed when working with a match result.
            //For example, let's extract the username and domain from an email address:

            //at top
            //using System;
            //using System.Text.RegularExpressions;
            //at top

            string pattern = @"^(?<username>[a-zA-Z0-9._%+-]+)@(?<domain>[a-zA-Z0-9.-]+\.[a-zA-Z]{2,})$";
            //Pattern Breakdown
            // ^ - This symbol indicates the start of the string.
            // (?<username>[a-zA-Z0-9._%+-]+) - This is a named capturing group called "username". It matches one or more characters that can be lowercase letters (a-z), uppercase letters (A-Z), digits (0-9), periods (.), underscores (_), percent signs (%), plus signs (+), or hyphens (-).
            // @ - This symbol matches the at sign (@) in the email address, separating the username from the domain.
            // (?<domain>[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}) - This is another named capturing group called "domain". It consists of two parts:
                //[a-zA-Z0-9.-]+ - This part matches one or more characters that can be lowercase letters (a-z), uppercase letters (A-Z), digits (0-9), periods (.), or hyphens (-). This will match the main part of the domain before the top-level domain (e.g., "example" in "example.com").

                //\.[a-zA-Z]{2,} - This part matches a period (.) followed by two or more lowercase (a-z) or uppercase (A-Z) letters. This will match the top-level domain (e.g., ".com" in "example.com").
            // $ - This symbol indicates the end of the string.
            // Putting it all together, this pattern describes an email address that starts with a username containing allowed characters, followed by the '@' symbol, and ends with a domain containing allowed characters and a top-level domain.
            string email = "example@example.com";

            Match match = Regex.Match(email, pattern);

            if (match.Success)
            {
                string username = match.Groups["username"].Value;
                string domain = match.Groups["domain"].Value;

                Console.WriteLine($"Username: {username}");
                Console.WriteLine($"Domain: {domain}");
            }

            //In this example, named capturing groups are used to extract the username and domain parts of the email address. The (?<name>...) syntax defines a named group, which can later be accessed by its name using the Groups property of the Match object.
            //Regular expressions are a powerful tool for text processing, but they can be complex and difficult to read. It's important to use them judiciously and practice to become proficient.
        }

        //File I/O Basics
        //File I/O (Input/Output) in C#. File I/O is the process of reading from or writing to a file. In C#, you can work with files using the System.IO namespace, which provides various classes for handling files and directories.

        public class FileIOLesson
        {
            //Reading and Writing Text Files
            //To read and write text files, you can use the File and StreamReader/StreamWriter classes. Here's an example of writing a text file using the File class:

            //at top
            //using System;
            //using System.IO;
            //at top

            string filePath = @"C:\example.txt";
            string[] lines = { "Line 1", "Line 2", "Line 3" };

            File.WriteAllLines(filePath, lines);

            //In this example, the File.WriteAllLines() method is used to write an array of strings to a file. The file will be created if it doesn't exist or overwritten if it does.

            //To read the contents of a text file, you can use the File class like this:

            //at top
            //using System;
            //using System.IO;
            //at top

            string filePath = @"C:\example.txt";
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            //The File.ReadAllLines() method reads all lines from the specified file into an array of strings.

            //Working with StreamReader and StreamWriter
            //The StreamReader and StreamWriter classes can be used for more control over file I/O operations. Here's an example of writing to a text file using a StreamWriter:

            //at top
            //using System;
            //using System.IO;
            //at top

            string filePath = @"C:\example.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Line 1");
                writer.WriteLine("Line 2");
                writer.WriteLine("Line 3");
            }

            //In this example, a StreamWriter is used to write lines to a file. The using statement ensures that the StreamWriter is properly disposed of after the file is written.
            //To read a text file using a StreamReader, you can do the following:

            //at top
            //using System;
            //using System.IO;
            //at top

            string filePath = @"C:\example.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            //In this example, a StreamReader is used to read lines from a file one at a time until the end of the file is reached.
        }

        //Exception Handling Advanced
        //An exception is an unexpected event that occurs during the execution of a program. Exceptions can lead to errors and crashes if not handled properly. In C#, exceptions are represented by instances of classes derived from the System.Exception class.
        //You can handle exceptions using a try-catch block. The try block contains the code that might throw an exception, and the catch block contains the code to handle the exception if it occurs. You can also use an optional finally block to specify code that should always be executed, regardless of whether an exception was thrown or not.

        //Here's an example of exception handling:

        public class ExcHandAdvLesson
        {
            class Program
            {
                static void Main(string[] args)
                {
                    int[] numbers = { 1, 2, 3 };

                    try
                    {
                        Console.WriteLine(numbers[3]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("This message will always be displayed.");
                    }
                }
            }
            //In this example, an IndexOutOfRangeException is thrown when trying to access an invalid index in the array. The catch block catches this exception and displays a custom error message. The finally block then executes, regardless of whether an exception was thrown.

            //Catching Multiple Exception Types
            //You can catch multiple exception types using multiple catch blocks. Here's an example:
            class ProgramB
            {
                static void Main(string[] args)
                {
                    try
                    {
                        // Code that might throw an exception
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine("An ArgumentNullException occurred: " + ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("An ArgumentException occurred: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An unexpected error occurred: " + ex.Message);
                    }
                }
            }
            //In this example, different catch blocks are used to handle ArgumentNullException, ArgumentException, and a generic Exception for other unexpected errors.

            //Throwing Exceptions
            //You can throw your own exceptions using the throw keyword, like this:

            class Program
            {
                static void Main(string[] args)
                {
                    try
                    {
                        TestMethod(null);
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }

                static void TestMethod(string input)
                {
                    if (input == null)
                    {
                        throw new ArgumentNullException(nameof(input), "Input cannot be null.");
                    }

                    // Rest of the method implementation
                }
            }

            //In this example, the TestMethod throws an ArgumentNullException when the input is null. The Main method catches this exception and displays an error message.
        }
    }   
}
