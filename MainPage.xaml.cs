using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MauiAppCenter;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		Analytics.TrackEvent("Counter clicked", new Dictionary<string, string> { { "Count", count.ToString() } });
    }

	private void OnExceptionClicked(object sender, EventArgs e)
	{
        //simulate exception
        Crashes.TrackError(new Exception("Exception thrown from button click"));
    }
}

