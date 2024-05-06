namespace KursovayaLast
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            nameInput = new TextBox();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.Location = new Point(12, 12);
            openButton.Name = "openButton";
            openButton.Size = new Size(117, 30);
            openButton.TabIndex = 0;
            openButton.Text = "Открыть";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 48);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(117, 30);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 113);
            addButton.Name = "addButton";
            addButton.Size = new Size(117, 30);
            addButton.TabIndex = 3;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "FirstFile.txt", "SecondFile.txt", "ThirdFile.txt" });
            listBox1.Location = new Point(160, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 379);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 342);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(404, 12);
            label1.MaximumSize = new Size(400, 100);
            label1.MinimumSize = new Size(365, 30);
            label1.Name = "label1";
            label1.Size = new Size(365, 30);
            label1.TabIndex = 6;
            label1.Text = "Содержимое файла";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(12, 84);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(117, 23);
            nameInput.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(nameInput);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(openButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openButton;
        private Button deleteButton;
        private Button addButton;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox nameInput;
    }
}