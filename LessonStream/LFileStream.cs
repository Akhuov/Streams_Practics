
using System.Text;


namespace LessonStream
{
    internal class LFileStream
    {

        string path = "ice.txt";
        
        public void Read()
        {
            //FileStream f = new FileStream(path, FileMode.Append);
            FileStream f = new FileStream(path, FileMode.Open);
            //Console.OutputEncoding = Encoding.UTF32;
            char a = (char)f.ReadByte();
            Console.WriteLine(a);
            f.Close();
            //Console.ReadLine();
        }

        public void Write()
        {

            using (var r = new StreamWriter(path, true, Encoding.UTF8))
            {
                r.WriteLine("Hello World");
            }
            //FileStream f = new FileStream(path, FileMode.Append);

            //f.WriteByte(70);

            //f.Close();
        }
    }
}
