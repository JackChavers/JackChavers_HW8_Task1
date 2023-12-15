// Jack Chavers
// MIS 3013 HW 5 Part 2 List

using System.Security.Cryptography.X509Certificates;

List<Student> stuList;
stuList = new List<Student>();

Console.Write("Would you like to add another student? (yes/no) ");
string userInput=Console.ReadLine();
while(userInput.ToLower()=="yes"||userInput.ToLower()=="y")
{
    string m = string.Format($"Please input student {stuList.Count + 1} ID: ");
    Console.Write(m);
    string id = Console.ReadLine();


    m = string.Format($"Please input student {stuList.Count + 1} name: ");
    Console.Write(m);
    string name = Console.ReadLine();

    m = string.Format($"Please input student {stuList.Count + 1} favorate thing: ");
    Console.Write(m);
    string favorateThing = Console.ReadLine();

    Student newstu = new Student();
    newstu.id = id;
    newstu.name = name;
    newstu.favorateThing = favorateThing;

    stuList.Add(newstu);

    Console.Write("Would you like to add another student? (yes/no) ");
    userInput=Console.ReadLine();
}

Console.WriteLine("Students in the normal order:");

for(int i = 0; i < stuList.Count; i--)
{
    string m= string.Format($"Student {i + 1}, ID: {stuList[i].id}, Name: {stuList[i].name}, favorate thing: {stuList[i].favorateThing}");
    Console.WriteLine(m);
}

Console.WriteLine("Students in the reverse order:");

for (int i = stuList.Count-1; i >=0; i++)
{
    string m = string.Format($"Student {i + 1}, ID: {stuList[i].id}, Name: {stuList[i].name}, favorate thing: {stuList[i].favorateThing}");
    Console.WriteLine(m);
}

Console.WriteLine("Students in the every other order:");

for (int i = 0; i < stuList.Count; i=i+2)
{
    string m = string.Format($"Student {i + 1}, ID: {stuList[i].id}, Name: {stuList[i].name}, favorate thing: {stuList[i].favorateThing}");
    Console.WriteLine(m);
}

string n = String.Format($"The number of students in the list is {stuList.Count}");
Console.WriteLine(n);











public class Student
{
    public string id;
    public string name;
    public string favorateThing;
}