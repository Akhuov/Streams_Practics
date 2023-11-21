

namespace LessonStream
{
    internal class LTextReader
    {
        string path = "test.txt";
        public void Read()
        {
            TextReader text_reader = File.OpenText(path);

            //ASCII 
            //var result = text_reader.Read();
            //Console.WriteLine(result);

            //char[] value = new char[2];
            //text_reader.ReadBlock(value, 0, 2);
            //Console.Read();

            var value = text_reader.ReadLine();
            var value2 = text_reader.ReadToEnd();

            Console.Read();

            //using (TextReader text_reader = File.OpenText(path))
            //{
            //    //user code
            //}
        }
    }
}
