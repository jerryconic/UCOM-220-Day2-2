using System.IO;

StreamReader rd = new StreamReader(@"C:\temp\test.txt");
Console.WriteLine(rd.ReadToEnd());
rd.Close();
