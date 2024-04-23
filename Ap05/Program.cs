using System.IO;

StreamWriter wr = new StreamWriter(@"C:\temp\test.txt");
for(int i = 1; i<= 10; i++)
{
    wr.WriteLine($"Hello world!{i}");
}
wr.Close();
