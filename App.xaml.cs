using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MauiAppCenter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //these are just for my test app - no real secrets here
        AppCenter.Start("ios=14640cf6-a71f-4d11-b54f-5fbc87cb1a25;" +
                  "windowsdesktop=bc07e88d-183e-491c-bf5a-7be0eef931fa;" +
                  "android=427fca12-c72f-470b-8528-44f1155e5f56;" +
                  "macos=d1ed7021-2687-4e13-80ff-35d7f6015c74;",
                  typeof(Analytics), typeof(Crashes));

        MainPage = new AppShell();
	}
}
