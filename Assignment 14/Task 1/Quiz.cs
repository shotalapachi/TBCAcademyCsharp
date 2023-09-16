using System;
using System.IO;

namespace Task_1
{
    public class Quiz
    {
        private string _name;
        private string _path;
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Path
        {
            get => _path;
            set => _path = value;
        }
        
        public Quiz(string name, string path)
        {
            _name = name;
            _path = path;
        }
        
        public void CreateQuiz(string path)
        {
            try
            {
                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine("Test");
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}