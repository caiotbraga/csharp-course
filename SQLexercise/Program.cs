using SQLexercise.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
try
{
    Console.Write("Write the path: ");
    String path = Console.ReadLine();
    Console.WriteLine("Insert salary: ");
    Double salary = double.Parse(Console.ReadLine());

    List<PersonInfo> list = new List<PersonInfo>();

    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            String[] text = sr.ReadLine().Split(", ");
            String names = text[0];
            String emails = text[1];
            Double salarys = Double.Parse(text[2], CultureInfo.InvariantCulture);

            list.Add(new PersonInfo(names, emails, salarys));
        }
    }
    var moreThan2000 = list.Where(obj => obj.salary > salary).OrderBy(obj => obj.email).Select(obj => obj.email);
    //var moreThan2000 = list.Where(pi => pi.salary > salary).OrderBy(email => email).ToList();
    Console.WriteLine("Emails of people whose have more than " + salary + ": ");
    foreach (var item in moreThan2000)
    {
        Console.WriteLine(item);
    }
    Console.Write("Sum of salary of people whose names start with 'M': ");
    var sum = list.Where(pi => pi.name.StartsWith('M')).Sum(obj => obj.salary);
    Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
}
catch (Exception)
{

    throw;
}