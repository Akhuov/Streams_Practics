using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonStream
{
    internal class LStreamReader
    {
        public void Read(string path)
        {
            using (var r = new StreamReader(path))
            {
                // oxiri bo'lmaguncha
                while (!r.EndOfStream)
                {
                    Console.WriteLine(r.ReadLine());
                }

                //r.DiscardBufferedData();
                r.BaseStream.Seek(0, SeekOrigin.Begin);

                var text = r.ReadToEnd().Split("\r\n");
                Console.WriteLine(text[0]);
            }
        }
    }
}
