using ZXing.Net.Maui;

namespace MauiApp1.Pages;

public partial class QRReader : ContentPage
{
    private string valorQr;

    public QRReader()
	{
		InitializeComponent();
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(async () =>
        {
            valorQr = $"{e.Results[0].Value} {e.Results[0].Format}";
            barcodeResult.Text = valorQr;
            if (valorQr != "")
                barcodeResult.Text = "Entre";
                await Navigation.PopAsync();
        });
    }
}