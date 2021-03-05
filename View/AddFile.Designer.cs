namespace CSVLabOne.View
{
    partial class AddFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.setPath_button = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.create_Button = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setPath_button
            // 
            this.setPath_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setPath_button.Location = new System.Drawing.Point(255, 32);
            this.setPath_button.Name = "setPath_button";
            this.setPath_button.Size = new System.Drawing.Size(88, 31);
            this.setPath_button.TabIndex = 0;
            this.setPath_button.Text = "Выбрать";
            this.setPath_button.UseVisualStyleBackColor = true;
            this.setPath_button.Click += new System.EventHandler(this.setPath_button_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPath.Location = new System.Drawing.Point(12, 9);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(60, 20);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "Путь: ";
            // 
            // create_Button
            // 
            this.create_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Button.Location = new System.Drawing.Point(255, 127);
            this.create_Button.Name = "create_Button";
            this.create_Button.Size = new System.Drawing.Size(88, 34);
            this.create_Button.TabIndex = 2;
            this.create_Button.Text = "Создать";
            this.create_Button.UseVisualStyleBackColor = true;
            this.create_Button.Click += new System.EventHandler(this.create_Button_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(13, 92);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя: ";
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.create_Button);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.setPath_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создать файл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setPath_button;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button create_Button;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
    }
}