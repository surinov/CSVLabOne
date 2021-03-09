using System;
using System.Windows.Forms;

namespace CSVLabOne.View
{
    public partial class AddFile : Form
    {
        private string _path;
        private readonly AddPath _addPath;
        public AddFile(AddPath sender)
        {
            _addPath = sender;
            InitializeComponent();
        }

        private void setPath_button_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != DialogResult.OK) return;
            _path = fbd.SelectedPath;
            labelPath.Text = _path;
        }

        private void create_Button_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != string.Empty)
            {
                SetPath();
                Close();
            }
            else
            {
                labelError.Text = @"Что-то не так";
            }
        }

        private void SetPath()
        {
            _addPath($"{_path}{textBoxName.Text}.csv");
        }
    }
}
