using net.sf.saxon.s9api;

namespace SaxonHEMauiNET7Test1;

public partial class MainPage : ContentPage
{

    private static readonly Processor processor = new Processor(true);

	public MainPage()
	{
		InitializeComponent();
        HWLabel.Text += $" Saxon {processor.getSaxonEdition()} {processor.getSaxonProductVersion()}";

    }

    private void SaxonDateTest_Clicked(object sender, EventArgs e)
    {

    }
}

