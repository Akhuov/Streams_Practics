using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonStream
{
    internal class LStreamWriter
    {
        public LStreamWriter(bool append = false)
        {
            Append = append;
        }

        private bool Append { get; set; }
        public string Path { get; set; } = "test.txt";

        public void Write()
        {
            var r = new StreamWriter(Path, Append, Encoding.UTF8);
            r.WriteLine("Hello World");
            r.Close();
            Console.Read();
            //r.Dispose();
        }

        public void WriteWithStream()
        {

            FileStream f = new FileStream(Path, FileMode.OpenOrCreate);

            Console.WriteLine("File opened");

            //declared stream writer
            StreamWriter s = new StreamWriter(f);

            Console.WriteLine("Writing data to file");

            s.WriteLine("Writing data into file using stream writer");

            //closing stream writer
            s.Close();
            f.Close();

            Console.WriteLine("File Stream closed");

            Console.ReadLine();
        }

        public void WriteWithUsing()
        {
            using (var r = new StreamWriter(Path, Append, Encoding.UTF8))
            {
                r.WriteLine("Hello World");
            }
        }
    }
}
