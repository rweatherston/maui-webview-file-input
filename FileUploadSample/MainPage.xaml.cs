namespace FileUploadSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

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

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
