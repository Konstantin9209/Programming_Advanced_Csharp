 Dictionary<string, string> registars = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i <n; i++)
{
    string[] commandArray = Console.ReadLine().Split().ToArray();

    string command = commandArray[0];
    string employee = commandArray[1];

    if (command == "register")
    {
        string plateNumber = commandArray[2];
        if (!registars.ContainsKey(employee))
        {
            registars.Add(employee, plateNumber);
            Console.WriteLine($"{employee} registered {plateNumber} successfully");

        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {registars[employee]}");
        }
    }
    else if (command == "unregister")
    {
        if (registars.ContainsKey(employee))
        {
            registars.Remove(employee);
            Console.WriteLine($"{employee} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {employee} not found");
        }
    }
}

foreach (KeyValuePair<string, string> pair in registars)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}