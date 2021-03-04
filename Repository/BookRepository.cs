using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CSVLabOne.Model;

namespace CSVLabOne.Repository
{
    class BookRepository
    {
        public string Path { get; set; }

        public BookRepository()
        {
            Path = "file.csv";
        }
        public List<Book> GetBooks()
        {
            var outp = new List<Book>();

            using (var reader = new StreamReader("file.csv"))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<Book>();
                foreach (var r in records)
                {
                    // не может найти поле ID !!
                    outp.Add(new Book(){Author = r.Author, Id = r.Id, Publisher = r.Publisher, Name = r.Name, Year = r.Year});
                }
            }

            return outp;
        }

        public bool AddBook(Book book)
        {
            var data = new[]
            {
                new Book()
                {
                    Id = book.Id,
                    Author = book.Author,
                    Name = book.Name,
                    Publisher = new Publisher() { Id = book.Publisher.Id, Name = book.Publisher.Name },
                    Year = book.Year
                }
            };
            using (var writer = new StreamWriter(Path))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.Delimiter = ";";
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.AutoMap<Book>();
                try
                {
                    csvWriter.WriteHeader<Book>();
                    csvWriter.WriteRecords(data);
                    writer.Flush();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool DeleteBook(int id)
        {
            return true;
        }

        public bool UpdateBook(Book book, int id)
        {
            return true;
        }
    }
}
