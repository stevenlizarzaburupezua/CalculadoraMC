using CalculadoraMC.MVVM.Views;

namespace CalculadoraMC;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BMIView();
	}
}
