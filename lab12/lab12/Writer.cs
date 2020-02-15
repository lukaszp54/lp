using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab12
{
    public class Writer
    {


        public void WriteToFile(Person person, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"[{person.Id}] {person.Name} {person.LastName}: {person.Phone}");
            }

        }

        public void WritePhoneNumbers(IEnumerable<Person> col, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var item in col)
                {
                    writer.WriteLine($"{item.Phone}");
                }
            }

        }

        public void WriteTenPhoneNumbersToFile(IEnumerable<Person> col)
        {
            List<Person> list = col.ToList();

            string fileName;
            int number = 0;
            string prefix = "result-";


            while (list.Count > number * 10)
            {
                fileName = prefix + ++number + ".txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {

                    var nextLine = list.Skip((number - 1) * 10).Take(10);

                    foreach (var item in nextLine)
                    {
                        writer.WriteLine($"[{item.Phone}]");
                    }
                }
            }
        }

        public void WriteLetters(IEnumerable<Person> col)
        {
            List<Person> list = col.ToList();
            string fileName;

            for (int i = 65; i < 91; i++)
            {
                char c = Convert.ToChar(i);
                fileName = "LastName on " + c + ".txt";


                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    var people = list.Where(x => x.LastName[0].Equals(c)).ToList();
                    foreach (var person in people)
                    {
                        writer.WriteLine($"[{person.LastName}, {person.Name}, {person.Phone}]");
                    }
                }

            }





        }
    }
}
