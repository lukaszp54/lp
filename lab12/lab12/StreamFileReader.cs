﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab12
{
    public class StreamFileReader : IReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            string data;
            using (var reader = new StreamReader(fileName))
            {
                data = reader.ReadToEnd();
            }

            string[] lines = data.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var people = lines.Select(x => CSVStringToPersonConverter.Convert(x));
            return people.ToList();
        }
    }
}
