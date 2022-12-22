using CalculadoraMC.MVVM.ViewModels;

namespace CalculadoraMC.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}