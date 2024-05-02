namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Expense> expenses = new List<Expense>();
        public Form1()
        {
            InitializeComponent();

            categoryComboBox.Items.AddRange(new string[] { "Їжа", "Транспорт", "Одяг", "Розваги", "Житло", "Інше" });

            UpdateExpenseStatistics();
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || categoryComboBox.SelectedIndex == -1 || !decimal.TryParse(amountTextBox.Text, out decimal amount))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }

            Expense expense = new Expense
            {
                Name = nameTextBox.Text,
                Category = categoryComboBox.SelectedItem.ToString(),
                Amount = amount
            };
            expenses.Add(expense);

            UpdateExpenseStatistics();

            nameTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            amountTextBox.Clear();
        }

        private void sortExpensesButton_Click(object sender, EventArgs e)
        {
            expenses = expenses.OrderBy(expense => expense.Amount).ToList();

            UpdateExpenseList();
        }

        private void UpdateExpenseStatistics()
        {
            var expenseStatistics = expenses
                .GroupBy(expense => expense.Category)
                .Select(group => new
                {
                    Category = group.Key,
                    TotalAmount = group.Sum(expense => expense.Amount)
                });

            statisticsListBox.Items.Clear();
            foreach (var stat in expenseStatistics)
            {
                statisticsListBox.Items.Add($"{stat.Category}: {stat.TotalAmount}");
            }

            UpdateExpenseList();
        }

        private void UpdateExpenseList()
        {
            expensesListBox.Items.Clear();
            foreach (var expense in expenses)
            {
                expensesListBox.Items.Add($"{expense.Name} - {expense.Category} - {expense.Amount}");
            }
        }
    }

    public class Expense
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
    }
}

