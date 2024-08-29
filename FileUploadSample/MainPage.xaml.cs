namespace FileUploadSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        WebView.Source = new HtmlWebViewSource
        {
            Html =
                """
                    <html>
                        <body>
                            <div>
                                <h3>Testing file input type</h3>
                                <form>
                                    <label for="file">Select a file: </label>
                                    <input name="file" type="file" />
                                </form>
                            </div>
                        </body>
                    </html>
                """
        };
    }
}