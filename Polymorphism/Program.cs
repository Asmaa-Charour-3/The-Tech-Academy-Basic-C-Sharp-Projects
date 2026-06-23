using System;   // Bringing in the core .NET utilities — the bread and butter of console apps

// 🧩 This interface represents something that can "quit" — a contract for quitting behavior
public interface IQuittable
{
    void Quit();   // 🎤 The one rule of this interface: anything implementing it must define Quit()
}

// 🧑‍💼 Employee class: now upgraded to implement IQuittable
public class Employee : IQuittable
{
    // 🔑 Unique identifier for each employee
    public int Id { get; set; }

    // 📝 Employee's first name
    public string FirstName { get; set; }

    // 📝 Employee's last name
    public string LastName { get; set; }

    // 🎭 Implementation of the Quit() method — our chance to add personality
    public void Quit()
    {
        // 🎬 Dramatic exit message — this is where the employee "quits"
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 🏗️ Creating a new Employee object — our star of the show
        Employee emp = new Employee
        {
            Id = 202,
            FirstName = "Asmaa",
            LastName = "Charour"
        };

        // 🎭 POLYMORPHISM MAGIC:
        //     We treat the Employee object as an IQuittable type.
        //     This works because Employee *implements* IQuittable.
        IQuittable quitter = emp;

        // 🎬 Calling Quit() through the interface reference — polymorphism in action
        quitter.Quit();

        // ⏳ Keeping the console open so the user can admire the output
        Console.ReadLine();
    }
}
