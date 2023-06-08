using IronOcr;

namespace IronOCR_MAUI_Test;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        var ocr = new IronTesseract();
        using (var input = new OcrInput())
        {
            input.AddImage(@"test.jpg");
            input.AddPdf("result.pdf");
            OcrResult result = ocr.Read(input);
            string text = result.Text;
        }
    }
    private void ImageOCR(object sender, EventArgs e)
    {
        var ocr = new IronTesseract();
        using (var input = new OcrInput())
        {
            input.AddImage(@"test.jpg");
            OcrResult result = ocr.Read(input);
            string text = result.Text;
            outputText.Text = text;
        }
    }
}

