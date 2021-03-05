using System;
using System.Windows.Forms;
using CSVLabOne.Model;
using CSVLabOne.Repository;
using CSVLabOne.View;

namespace CSVLabOne
{
    public delegate void AddBook(Book book);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addForm = new AddItem(AddBook);
            addForm.Show();
        }

        private void AddBook(Book book)
        {
            var repo = new BookRepository();
            if (repo.AddBook(book))
            {
                UpdateRows();
                labelLog.Text = @"Log: Добавлено";
            }
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            UpdateRows();
        }

        private void UpdateRows()
        {
            dataGridView1.Rows.Clear();
            var repo = new BookRepository();
            var book = repo.GetBooks();
            foreach (var item in book)
            {
                dataGridView1.Rows.Add(item.Id.ToString(), item.Author, item.Name, item.Year, item.Publisher.PubId, item.Publisher.PubName);
            }
            labelLog.Text = @"Log: Обновлено";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var repo = new BookRepository();
            if (repo.CreateBook())
            {
                labelLog.Text = @"Log: Создано";
            }
        }
    }
}
