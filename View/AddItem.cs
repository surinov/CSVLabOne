using System;
using System.Windows.Forms;
using CSVLabOne.Model;

namespace CSVLabOne.View
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TextBoxIsNullOrEmpty())
            {
                var book = MakeBook(textBoxName.Text, textBoxAuthor.Text, textBoxPublisher.Text, int.Parse(textBoxYear.Text));
                MessageBox.Show($"{book.Id} {book.Name} {book.Author} {book.Year}; {book.Publisher.Id}-{book.Publisher.Name}");
            }
            else
            {
                labelError.Text = @"Неверно введены данные!";
            }
        }

        private bool TextBoxIsNullOrEmpty()
        {
            return textBoxName.Text == string.Empty || textBoxAuthor.Text == string.Empty || textBoxYear.Text == string.Empty || !int.TryParse(textBoxYear.Text, out var num) ||
                   textBoxPublisher.Text == string.Empty;
        }

        private Book MakeBook(string name, string author, string publisher, int year)
        {
            // здесь был похоронен рандомайзер наследия С++, который выдавал одинаковые значения при вызове в один момент времени. Press F to pay respect

            var id = new Random().Next(100000, 500000);
            var pubid = new Random().Next(500000, 1000000);
            var book = new Book()
            {
                Author = author,
                Id = id,
                Publisher = new Publisher() { Id = pubid, Name = publisher },
                Name = name,
                Year = year
            };

            return book;
        }
    }
}
