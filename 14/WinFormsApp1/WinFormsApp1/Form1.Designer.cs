namespace WinFormsApp1
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
            nameTextBox = new TextBox();
            amountTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            addExpenseButton = new Button();
            sortExpensesButton = new Button();
            expensesListBox = new ListBox();
            statisticsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 0;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(119, 27);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(100, 23);
            amountTextBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(79, 69);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 2;
            // 
            // addExpenseButton
            // 
            addExpenseButton.Location = new Point(238, 48);
            addExpenseButton.Name = "addExpenseButton";
            addExpenseButton.Size = new Size(110, 23);
            addExpenseButton.TabIndex = 3;
            addExpenseButton.Text = "Додати витрату";
            addExpenseButton.UseVisualStyleBackColor = true;
            addExpenseButton.Click += addExpenseButton_Click;
            // 
            // sortExpensesButton
            // 
            sortExpensesButton.Location = new Point(116, 307);
            sortExpensesButton.Name = "sortExpensesButton";
            sortExpensesButton.Size = new Size(75, 23);
            sortExpensesButton.TabIndex = 4;
            sortExpensesButton.Text = "Сортувати";
            sortExpensesButton.UseVisualStyleBackColor = true;
            sortExpensesButton.Click += sortExpensesButton_Click;
            // 
            // expensesListBox
            // 
            expensesListBox.FormattingEnabled = true;
            expensesListBox.ItemHeight = 15;
            expensesListBox.Location = new Point(12, 117);
            expensesListBox.Name = "expensesListBox";
            expensesListBox.Size = new Size(269, 184);
            expensesListBox.TabIndex = 5;
            // 
            // statisticsListBox
            // 
            statisticsListBox.FormattingEnabled = true;
            statisticsListBox.ItemHeight = 15;
            statisticsListBox.Location = new Point(324, 117);
            statisticsListBox.Name = "statisticsListBox";
            statisticsListBox.Size = new Size(269, 184);
            statisticsListBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Назва";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 8;
            label2.Text = "Витрачені кошти";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 72);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Категорія";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 347);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statisticsListBox);
            Controls.Add(expensesListBox);
            Controls.Add(sortExpensesButton);
            Controls.Add(addExpenseButton);
            Controls.Add(categoryComboBox);
            Controls.Add(amountTextBox);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox amountTextBox;
        private ComboBox categoryComboBox;
        private Button addExpenseButton;
        private Button sortExpensesButton;
        private ListBox expensesListBox;
        private ListBox statisticsListBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
