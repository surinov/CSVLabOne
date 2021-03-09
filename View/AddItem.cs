using System;
using System.Windows.Forms;
using CSVLabOne.Model;

namespace CSVLabOne.View
{
    public partial class AddItem : Form
    { 
        
        private readonly AddBook _addBook;
        private readonly EditBook _editBook;
        private int _id;
        private int _pubid;
        private string _author;
        private string _name;
        private string _pubName;
        private int _year;
        private bool Edit = false;
        public AddItem(AddBook sender)
        {
            _addBook = sender;
            InitializeComponent();
        }
        public AddItem(EditBook sender, string name, string author, string pubName, int year, int id, int pubid, bool edit)
        {
            _editBook = sender;
            _author = author;
            _name = name;
            _pubName = pubName;
            _year = year;
            _id = id;
            _pubid = pubid;
            Edit = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TextBoxIsNullOrEmpty())
            {
                if (Edit)
                {
                    var bookE = MakeBook(textBoxName.Text, textBoxAuthor.Text, textBoxPublisher.Text, int.Parse(textBoxYear.Text), _id, _pubid);
                    _editBook(bookE);
                    Edit = false;
                    Close();
                }
                else
                {
                    var book = MakeBook(textBoxName.Text, textBoxAuthor.Text, textBoxPublisher.Text, int.Parse(textBoxYear.Text));
                    _addBook(book);
                    Close();
                }
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
            var book = new Book
            {
                Author = author,
                Id = id,
                Publisher = new Publisher { PubId = pubid, PubName = publisher },
                Name = name,
                Year = year
            };

            return book;
        }

        private Book MakeBook(string name, string author, string publisher, int year, int id, int pubid)
        {
            // здесь был похоронен рандомайзер наследия С++, который выдавал одинаковые значения при вызове в один момент времени. Press F to pay respect

            var book = new Book
            {
                Author = author,
                Id = id,
                Publisher = new Publisher { PubId = pubid, PubName = publisher },
                Name = name,
                Year = year
            };

            return book;
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            if (_author != string.Empty || _name != string.Empty || _pubName != string.Empty || _year != 0)
            {
                textBoxAuthor.Text = _author;
                textBoxName.Text = _name;
                textBoxPublisher.Text = _pubName;
                textBoxYear.Text = _year.ToString();
            }
        }
    }
}
