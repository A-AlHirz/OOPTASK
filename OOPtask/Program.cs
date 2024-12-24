using OOPtask.Models;

Student std = new Student();

string name, major;
double gpa;

Console.WriteLine("Name: ");
name = Console.ReadLine();

Console.WriteLine("Major: ");
major = Console.ReadLine();

Console.WriteLine("GPA: ");
gpa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(std.GetInfo(name, major, gpa));
