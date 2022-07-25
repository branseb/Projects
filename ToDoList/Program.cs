using System;
using FileReaders;

var adapter = new FileReaderAdapter();
adapter.RegisterReader(".txt", new TextFileReader());
adapter.RegisterReader(".json", new JsonFileReader());
adapter.RegisterWriter(".txt", new TextFileWriter());
adapter.RegisterWriter(".json", new JsonFileWriter());

var file = "C:\\test\\notes.json";
var oldrows = adapter.ReaderFile(file);
foreach (var row in oldrows)
{ 
    Console.WriteLine(row);
}

var rows = Console.ReadLine().Split(";").ToList();
rows = rows.Concat(oldrows).ToList();
adapter.WriteFile(file, rows);




