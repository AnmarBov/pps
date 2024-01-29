namespace SqlFormsApp
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
            checkedListBox1 = new CheckedListBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            editButton = new Button();
            one = new CheckBox();
            two = new CheckBox();
            listBox2 = new ListBox();
            addButton = new Button();
            deleteButton = new Button();
            exportButton = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(42, 38);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(271, 346);
            checkedListBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(407, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(271, 139);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(334, 141);
            button1.Name = "button1";
            button1.Size = new Size(30, 23);
            button1.TabIndex = 3;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(334, 186);
            button2.Name = "button2";
            button2.Size = new Size(30, 23);
            button2.TabIndex = 4;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(334, 232);
            editButton.Name = "editButton";
            editButton.Size = new Size(48, 23);
            editButton.TabIndex = 5;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // one
            // 
            one.AutoSize = true;
            one.Location = new Point(334, 38);
            one.Name = "one";
            one.Size = new Size(46, 19);
            one.TabIndex = 6;
            one.Text = "one";
            one.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            two.AutoSize = true;
            two.Location = new Point(334, 88);
            two.Name = "two";
            two.Size = new Size(46, 19);
            two.TabIndex = 7;
            two.Text = "two";
            two.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(407, 245);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(271, 139);
            listBox2.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(334, 288);
            addButton.Name = "addButton";
            addButton.Size = new Size(48, 23);
            addButton.TabIndex = 9;
            addButton.Text = "add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(334, 346);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(48, 23);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(602, 392);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(76, 46);
            exportButton.TabIndex = 11;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(listBox2);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(editButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(checkedListBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button editButton;
        private CheckBox one;
        private CheckBox two;
        private ListBox listBox2;
        private Button addButton;
        private Button deleteButton;
        private Button exportButton;
    }
}