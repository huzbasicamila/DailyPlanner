using DailyPlanner.Models;

namespace DailyPlanner;

public partial class App : Application
{
	public static UserInfo UserInfo;
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
