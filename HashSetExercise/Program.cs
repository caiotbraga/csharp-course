using HashSetExercise.Entities;

HashSet<Students> set = new HashSet<Students> ();
Console.WriteLine("How many Students for course A?");
int nA = int.Parse (Console.ReadLine ());
for (int i = 0; i < nA; i++) {
    int number = int.Parse (Console.ReadLine ());
    set.Add(new Students (number));
}
Console.WriteLine("How many Students for course B?");
int nB = int.Parse(Console.ReadLine());
for (int i = 0; i < nB; i++) {
    int number = int.Parse(Console.ReadLine());
    set.Add(new Students(number));
}
Console.WriteLine("How many Students for course C?");
int nC = int.Parse(Console.ReadLine());
for (int i = 0; i < nC; i++) {
    int number = int.Parse(Console.ReadLine());
    set.Add(new Students(number));
}
Console.WriteLine("Total Students: "+set.Count);

