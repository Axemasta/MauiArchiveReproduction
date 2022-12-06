using MyClassLib;

namespace ArchiveIssueReproduction;

public partial class MainPage : ContentPage
{
	int count = 0;

	private readonly Class1 class1;

	public MainPage()
	{
		InitializeComponent();

		class1 = new Class1();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

