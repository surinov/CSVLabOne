using System;
using System.Data.Odbc;
using System.Windows.Forms;
using CSVLabOne.Model;
using CSVLabOne.Repository;
using CSVLabOne.View;

namespace CSVLabOne
{
    public delegate void AddBook(Book book);
    public delegate void EditBook(Book book);
    public delegate void AddPath(string path);
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

        private void EditBook(Book book)
        {
            var repo = new BookRepository();
            repo.DeleteBook(book.Id);
            if (repo.UpdateBook(book, book.Id))
            {
                UpdateRows();
                labelLog.Text = @"Log: Изменено";
            }
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            UpdateRows();
            labelLog.Text = @"Log: Обновлено";
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
        }

        private void create_Button_Click(object sender, EventArgs e)
        {
            var newF = new AddFile(AddPath);
            newF.Show();
        }

        private void AddPath(string path)
        {
            var repo = new BookRepository();
            repo.Path = path;
            if (repo.CreateBook())
            {
                labelLog.Text = @"Log: Путь файла обновлен";
                labelDir.Text = $"Dir: {path}";
            }
            else
            {
                labelLog.Text = @"Log: Путь не добавлен";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelDir.Text = $"Dir: {new BookRepository().Path}";
        }

        private void open_Button_Click(object sender, EventArgs e)
        {
            var fbd = new OpenFileDialog {Filter = @"Файлы csv|*.csv"};
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var path = fbd.FileName;
                var repo = new BookRepository();
                repo.Path = path;
                labelLog.Text = @"Log: Путь файла обновлен";
                labelDir.Text = $"Dir: {path}";
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new BookRepository();
                if (repo.DeleteBook(int.Parse(GetSelectedValue(Id))))
                {
                    labelLog.Text = @"Log: Строка удалена";
                    UpdateRows();
                }
                else
                {
                    labelLog.Text = @"Log: Не удалено";
                }
            }
            catch
            {
                labelLog.Text = @"Log: Не удалено";
            }
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            var eForm = new AddItem(EditBook, GetSelectedValue(NameA), GetSelectedValue(Author), GetSelectedValue(Publisher), 
                int.Parse(GetSelectedValue(Year)), int.Parse(GetSelectedValue(Id)), int.Parse(GetSelectedValue(IdPub)), true);
            eForm.Show();
        }

        private string GetSelectedValue(DataGridViewBand item)
        {
            try
            {
                var rowindex = dataGridView1.CurrentCell.RowIndex;
                var selectedVal = dataGridView1.Rows[rowindex].Cells[item.Index].Value.ToString();
                if (string.IsNullOrEmpty(selectedVal))
                {
                    return null;
                }

                return selectedVal;
            }
            catch
            {
                return null;
            }
        }

        private void abaut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Визуальные средства разработки \nЛабораторная работа 1");
        }
    }
}
