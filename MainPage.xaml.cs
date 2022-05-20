namespace RangeCollectionDemo;

public partial class MainPage : ContentPage
{
    Random random = new Random();
	public ObservableRangeCollection<string> Items { get; } = new ();
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        var items = new[] { $"Item {random.Next(1, 100)}", $"Item {random.Next(1, 100)}", $"Item {random.Next(1, 100)}" };
        Items.AddRange(items);
    }

    private void CounterBtnClear_Clicked(object sender, EventArgs e)
    {
        Items.Clear();
    }
}

