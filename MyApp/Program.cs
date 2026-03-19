// string firstName = "Bob";
// int message = 3;
// decimal temperature = 34.4m;
// temperature = 34.4m;
// Console.Write("Hello ");
// Console.Write(firstName);
// Console.Write("! You have ");
// Console.Write(message);
// Console.Write(" message in you inbox. The Temperature is ");
// Console.Write(temperature);
// Console.Write(" Celcius");

// Console.WriteLine("Hello\nWorld");
// Console.WriteLine("Hello\tWorld");

// Console.WriteLine("Generating Invoice for customer \"Constoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tCompleted!");
// Console.Write("\nOutput Direct: \t");
// Console.WriteLine(@"c:\invoices");

// int version = 11;
// string updateText = "Upgrade to Windows";
// string message = $"{updateText} {version}";
// Console.WriteLine(message);

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishMsg = ($@"c:\Exercise\{projectName}\data.txt");
string russianMsg = ($@"c:\Exercise\{russianMessage}\data.txt");
Console.WriteLine(englishMsg);
Console.Write(russianMsg);