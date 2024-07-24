if (args.Length <= 0) throw new ArgumentException("Please supply arguments.");

var filePath = args[0];

if (!File.Exists(filePath)) throw new FileNotFoundException($"Cannot find file {filePath} to edit.");

var text = File.ReadAllText(filePath);
text += "\r\nActioned.";
File.WriteAllText(filePath, text);
