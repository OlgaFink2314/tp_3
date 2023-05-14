using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_3
{
    public class FileReader
    {
        private string _filePath;


        public FileReader(string filePath)
        {
            _filePath = filePath;


        }



        public string ReadFileContent()
        {
            string fileContent = null;

            if (File.Exists(_filePath))
            {
                fileContent = File.ReadAllText(_filePath);
            }

            return fileContent;
        }

        public Data ReadIntoData()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            // Открываем файл для чтения
            StreamReader reader = new StreamReader(_filePath);

            // Создаем два списка для хранения строк

            // Читаем первую строку и добавляем ее в первый список
            string line = reader.ReadLine();
            if (line != null)
            {
                string[] words = line.Split(new char[] { ' ' });
                foreach (string word in words)
                {
                    list1.Add(int.Parse(word));
                }
            }

            // Читаем вторую строку и добавляем ее во второй список
            line = reader.ReadLine();
            if (line != null)
            {
                string[] words = line.Split(new char[] { ' ' });
                foreach (string word in words)
                {
                    list2.Add(int.Parse(word));
                }
            }

            //return line;
            // Закрываем файл
            reader.Close();

            return new Data(list1, list2);
        }

    }
}

