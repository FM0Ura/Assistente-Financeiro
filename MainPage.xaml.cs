using System.Collections.ObjectModel;

namespace FinanceAssistant;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Transaction> Transactions { get; set; }

    public MainPage()
    {
        InitializeComponent();
        Transactions = new ObservableCollection<Transaction>();
        TransactionsListView.ItemsSource = Transactions;
    }

    private void OnAddTransactionClicked(object sender, EventArgs e)
    {
        var description = DescriptionEntry.Text;
        var amount = decimal.Parse(AmountEntry.Text);

        Transactions.Add(new Transaction { Description = description, Amount = amount });

        DescriptionEntry.Text = string.Empty;
        AmountEntry.Text = string.Empty;
    }
}

public class Transaction
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
}