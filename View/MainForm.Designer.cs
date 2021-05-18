namespace CSVLabOne
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_Button = new System.Windows.Forms.Button();
            this.create_Button = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.open_Button = new System.Windows.Forms.Button();
            this.labelDir = new System.Windows.Forms.Label();
            this.delete_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.abaut_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(676, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Author,
            this.NameA,
            this.Year,
            this.IdPub,
            this.Publisher});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id книги";
            this.Id.MinimumWidth = 80;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 90;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.MinimumWidth = 120;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 120;
            // 
            // NameA
            // 
            this.NameA.HeaderText = "Название";
            this.NameA.MinimumWidth = 125;
            this.NameA.Name = "NameA";
            this.NameA.ReadOnly = true;
            this.NameA.Width = 125;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.MinimumWidth = 80;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 80;
            // 
            // IdPub
            // 
            this.IdPub.HeaderText = "Id издателя";
            this.IdPub.MinimumWidth = 80;
            this.IdPub.Name = "IdPub";
            this.IdPub.ReadOnly = true;
            this.IdPub.Width = 80;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Издатель";
            this.Publisher.MinimumWidth = 120;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 120;
            // 
            // update_Button
            // 
            this.update_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_Button.Location = new System.Drawing.Point(931, 412);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(87, 30);
            this.update_Button.TabIndex = 2;
            this.update_Button.Text = "Обновить";
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // create_Button
            // 
            this.create_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Button.Location = new System.Drawing.Point(15, 471);
            this.create_Button.Name = "create_Button";
            this.create_Button.Size = new System.Drawing.Size(80, 30);
            this.create_Button.TabIndex = 4;
            this.create_Button.Text = "Создать";
            this.create_Button.UseVisualStyleBackColor = true;
            this.create_Button.Click += new System.EventHandler(this.create_Button_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(645, 539);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(36, 17);
            this.labelLog.TabIndex = 5;
            this.labelLog.Text = "Log:";
            // 
            // open_Button
            // 
            this.open_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_Button.Location = new System.Drawing.Point(15, 435);
            this.open_Button.Name = "open_Button";
            this.open_Button.Size = new System.Drawing.Size(80, 30);
            this.open_Button.TabIndex = 6;
            this.open_Button.Text = "Открыть";
            this.open_Button.UseVisualStyleBackColor = true;
            this.open_Button.Click += new System.EventHandler(this.open_Button_Click);
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(12, 415);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(26, 17);
            this.labelDir.TabIndex = 7;
            this.labelDir.Text = "Dir";
            // 
            // delete_Button
            // 
            this.delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Button.Location = new System.Drawing.Point(583, 415);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(90, 30);
            this.delete_Button.TabIndex = 9;
            this.delete_Button.Text = "Удалить";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // edit_Button
            // 
            this.edit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Button.Location = new System.Drawing.Point(490, 415);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(90, 30);
            this.edit_Button.TabIndex = 10;
            this.edit_Button.Text = "Изменить";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // abaut_Button
            // 
            this.abaut_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abaut_Button.Location = new System.Drawing.Point(15, 530);
            this.abaut_Button.Name = "abaut_Button";
            this.abaut_Button.Size = new System.Drawing.Size(155, 23);
            this.abaut_Button.TabIndex = 11;
            this.abaut_Button.Text = "О программе";
            this.abaut_Button.UseVisualStyleBackColor = true;
            this.abaut_Button.Click += new System.EventHandler(this.abaut_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 565);
            this.Controls.Add(this.abaut_Button);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.open_Button);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.create_Button);
            this.Controls.Add(this.update_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CSV CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.Button create_Button;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button open_Button;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.Button abaut_Button;
    }
}

