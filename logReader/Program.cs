using logReader.entidades;

HashSet<logRecord> set = new HashSet<logRecord>();
Console.Write("Enter full path: ");
String path = Console.ReadLine();

try {
	using (StreamReader sr = File.OpenText(path)) {
		while (!sr.EndOfStream) {
			string[] line = sr.ReadLine().Split(' ');
			string name = line[0];
			DateTime moment = DateTime.Parse(line[1]);
			set.Add(new logRecord(name, moment));
		}
        Console.WriteLine("Total users: "+set.Count);
    }
}
catch (Exception) {

	throw;
}
