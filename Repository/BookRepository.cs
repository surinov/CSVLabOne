using System.Collections.Generic;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
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
            var records = new List<Book>
            {
                new Book()
                {
                    Id = book.Id,
                    Author = book.Author,
                    Name = book.Name,
                    Publisher = new Publisher() { PubId = book.Publisher.PubId, PubName = book.Publisher.PubName },
                    Year = book.Year
                }
            };               
            try
            { 
                var config = new CsvConfiguration()
                {
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(Path, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool DeleteBook(int id)
        {
            return true;
        }
        // do
        public bool UpdateBook(Book book, int id)
        {
            var records = new List<Book>
            {
                new Book()
                {
                    Id = book.Id,
                    Author = book.Author,
                    Name = book.Name,
                    Publisher = new Publisher() { PubId = book.Publisher.PubId, PubName = book.Publisher.PubName },
                    Year = book.Year
                }
            };

            // Append to the file.
            var config = new CsvConfiguration()
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open(Path, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(records);
            }

            return true;
        }

        //do
        public bool CreateBook()
        {
            var records = new List<Book>
            {
                new Book()
                {
                    Id = 0,
                    Author = "",
                    Name = "",
                    Publisher = new Publisher() { PubId = 0, PubName = ""},
                    Year = 0
                }
            };
            using (var writer = new StreamWriter(Path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }

            return true;
        }
    }
}
