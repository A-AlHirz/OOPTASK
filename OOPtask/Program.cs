using OOPtask.Models;
#region Student
Student std = new Student();

string name, major;
double gpa;

Console.Write("Name: ");
name = Console.ReadLine();

Console.Write("Major: ");
major = Console.ReadLine();

Console.Write("GPA: ");
gpa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(std.GetInfo(name, major, gpa));
#endregion

Console.WriteLine("--------------------------");

#region Graduatestudent
Graduatestudent Gstd = new Graduatestudent();

string Gname, Gmajor;
double Ggpa;

Console.Write("\n Graduate Name: ");
Gname = Console.ReadLine();

Console.Write("Major: ");
Gmajor = Console.ReadLine();

Console.Write("GPA: ");
Ggpa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Gstd.GetInfo(Gname, Gmajor, Ggpa));

#endregion