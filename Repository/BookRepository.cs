using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using CSVLabOne.Model;

namespace CSVLabOne.Repository
{
    class BookRepository
    {
        public string Path = @"file.csv";

        public List<Book> GetBooks()
        {
            var outp = new List<Book>();

            using (var reader = new StreamReader(Path))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<Book>();
                foreach (var r in records)
                {
                    outp.Add(new Book(){Author = r.Author, Id = r.Id, Publisher = r.Publisher, Name = r.Name, Year = r.Year});
                }
                reader.Close();
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
                    writer.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool AddBook(Book book, int id)
        {
            var records = new List<Book>
            {
                new Book()
                {
                    Id = id,
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
                    writer.Close();
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
            try
            {
                List<Book> records;
                using (var reader = new StreamReader(Path))
                using (var csv = new CsvReader(reader))
                {
                    records = csv.GetRecords<Book>().ToList();

                    for (var i = 0; i < records.Count; ++i)
                    {
                        if (records[i].Id == id)
                        {
                            records.RemoveAt(i);
                        }
                    }
                    reader.Close();
                }

                using (var writer = new StreamWriter(Path))
                using (var csvWriter = new CsvWriter(writer))
                {
                    csvWriter.WriteRecords(records);
                    writer.Close();
                }

                return true;
            }
            catch { return false; }
        }

        public bool UpdateBook(Book book, int id)
        {
            try
            {
                List<Book> records;
                using (var reader = new StreamReader(Path))
                using (var csv = new CsvReader(reader))
                {
                    records = csv.GetRecords<Book>().ToList();

                    for (var i = 0; i < records.Count; ++i)
                    {
                        if (records[i].Id == id)
                        {
                            records.RemoveAt(i);
                        }
                    }
                    reader.Close();
                }

                using (var writer = new StreamWriter(Path))
                using (var csvWriter = new CsvWriter(writer))
                {
                    csvWriter.WriteRecords(records);
                    writer.Close();
                }

                AddBook(book, id);

                return true;
            }
            catch { return false; }
        }

        public bool CreateBook()
        {
            var records = new List<Book>{};
            using (var writer = new StreamWriter(Path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
                writer.Close();
            }

            return true;
        }
    }
}
