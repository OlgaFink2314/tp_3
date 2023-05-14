using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_3
{
    public class Reader
    {
        private string _path;
        public Reader(string path)
        {
            _path = path;


        }
        public string ReadFile(string _path)
        {
            StreamReader read = new StreamReader(_path);
            string add = read.ReadToEnd();
            read.Close();
            return add;
        }
        public Data_2 ReadData()
        {
            List<int> list_1 = new List<int>();
            List<int> list_2 = new List<int>();
            // Открываем файл для чтения

            StreamReader read = new StreamReader(_path);
            // Создаем два списка для хранения строк

            // Читаем первую строку и добавляем ее в первый список
            string line = read.ReadLine();
            if (line != null)
            {
                string[] words = line.Split(new char[] { ' ' });
                foreach (string word in words)
                {
                    list_1.Add(int.Parse(word));
                }
            }

            // Читаем вторую строку и добавляем ее во второй список
            line = read.ReadLine();
            if (line != null)
            {
                string[] words = line.Split(new char[] { ' ' });
                foreach (string word in words)
                {
                    list_2.Add(int.Parse(word));
                }
            }

            //return line;
            // Закрываем файл
            read.Close();

            return new Data_2(list_1, list_2);
        }
    }
}

