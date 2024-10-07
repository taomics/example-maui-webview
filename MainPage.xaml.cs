namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		LoadWebViewAsync();
	}

	private async Task LoadWebViewAsync()
	{
		var httpClient = new HttpClient();

		// set token
		httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_TOKEN");

		var response = await httpClient.GetStringAsync("URL");
		
		WebView.Source = new HtmlWebViewSource
		{
			Html = response
		};
	}
}
