var student1 = new Student("Mustafo", "Dushanbe", "C#", 16, 1000);
var student2 = new Student("Aleck", "New-York", "JS", 17, 2500);

var list1 = new List<Student>();
list1.Add(student1);
list1.Add(student2);
foreach (var item in list1)
{
    System.Console.WriteLine("Student: ");
    System.Console.WriteLine("Name: " + item.GetName());
    System.Console.WriteLine("Address: " + item.GetAddress());
    System.Console.WriteLine("Program: " + item.GetProgram());
    System.Console.WriteLine("AGE: " + item.GetYear());
    System.Console.WriteLine("Fee: " + item.GetFee());
    System.Console.WriteLine(item.ToString());
    System.Console.WriteLine("----------------------------------");

}


var staff1 = new Staff("Barotov", "California", "Cambrige", 1500);
var staff2 = new Staff("Salom", "Los-Angels", "Soft-Club", 2000);

var list = new List<Staff>();
list.Add(staff1);
list.Add(staff2);

foreach (var item in list)
{
    System.Console.WriteLine("Staff: ");
    System.Console.WriteLine("Name: " + item.GetName());
    System.Console.WriteLine("Address: " + item.GetAddress());
    System.Console.WriteLine("School: " + item.GetSchool());
    System.Console.WriteLine("Pay: " + item.GetPay());
    System.Console.WriteLine(item.ToString());
    System.Console.WriteLine("----------------------------------");
}