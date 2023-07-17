using System.Data.SqlTypes;

Dictionary<String, int> storage = new Dictionary<String, int>();

Console.Write("Write full path: ");
String path = Console.ReadLine();
StringReader str;

try {
    using (StreamReader sr = File.OpenText(path)) {
        while (!sr.EndOfStream) {
            string[] line = sr.ReadLine().Split(',');
            string name = line[0];
            int quantity = int.Parse(line[1]);
            if (storage.ContainsKey(name)){
                quantity = storage[name] + quantity;
                storage[name] = quantity;
            }
            else {
                storage.Add(name, quantity);
            }
        }
        Console.WriteLine("TOTAL VOTES: ");
        foreach (KeyValuePair<String, int> name in storage) {
            Console.WriteLine(name.Key +": "+storage[name.Key]);
        }
    }
}catch (Exception) {
    throw;
}




