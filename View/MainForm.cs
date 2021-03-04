using System;
using System.Windows.Forms;
using CSVLabOne.Model;
using CSVLabOne.Repository;
using CSVLabOne.View;

namespace CSVLabOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addForm = new AddItem();
            addForm.Show();
            /*var csv = new CSVWriter();
            csv.Main();
            //var book = new Book() { Author = }
            var id = int.Parse(dataGridView1[Id.Index, 0].Value.ToString());
            var name = dataGridView1[NameA.Index, 0].Value.ToString();
            var author = dataGridView1[Author.Index, 0].Value.ToString();
            var year = int.Parse(dataGridView1[Year.Index, 0].Value.ToString());
            var pubid = int.Parse(dataGridView1[IdPub.Index, 0].Value.ToString());
            var publisher = dataGridView1[Publisher.Index, 0].Value.ToString();
            var book = new Book()
            {
                Author = author, Id = id, Publisher = new Publisher() {Id = pubid, Name = publisher}, Name = name,
                Year = year
            };
            richTextBox1.Text =
                $"{book.Id} {book.Author} {book.Name} {book.Year} {book.Publisher.Id} {book.Publisher.Name}";*/
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            var repo = new BookRepository();
            var book = repo.GetBooks();
            foreach (var item in book)
            {
                richTextBox1.Text += $"{item.Name} \n";
            }
        }
    }
}
