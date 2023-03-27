
using MauiApp1.Data;

namespace MauiApp1;

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

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private async void OnQRLector(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Pages.Pagina1());

    }

	private async void OnPagina2(object sender, EventArgs e)
	{
		Class1 item = new Class1()
		{
			Title = "Ejemplo paginas de navegacion",
			IconSource = "contacto.png"
		};
		await Navigation.PushModalAsync(new Pages.Pagina2
		{
			BindingContext = item
		});
	}

	private async void OnQRReader(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new Pages.QRReader());
    }

}

