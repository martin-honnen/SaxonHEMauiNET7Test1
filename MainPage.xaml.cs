using net.sf.saxon.s9api;

namespace SaxonHEMauiNET7Test1;

public partial class MainPage : ContentPage
{

    private static readonly Processor processor = new(true);

	public MainPage()
	{
		InitializeComponent();
        HWLabel.Text += $" Saxon {processor.getSaxonEdition()} {processor.getSaxonProductVersion()}";

    }

    private void SaxonDateTest_Clicked(object sender, EventArgs e)
    {
        DateResult.Text = processor.newXPathCompiler().evaluateSingle("current-dateTime()", null).getStringValue();
    }
}

