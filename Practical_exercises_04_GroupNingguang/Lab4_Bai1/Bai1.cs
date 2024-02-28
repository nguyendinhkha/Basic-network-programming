namespace Lab4_Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        // Instantiate HttpClient once and re-used throughout the life of an application.
        private static readonly HttpClient client = new HttpClient();

        private async void btnGet_Click_1(object sender, EventArgs e)
        {
                // Get the url from textbox
                string url = getUrl.Text.Trim();
                if (url != string.Empty)
                {
                    /*
                     * Send a GET request to the url above
                     * Return the response body as a string in an asynchronous operation.
                     */
                    string responseString = await client.GetStringAsync(url);
                    if (responseString != string.Empty)
                    {
                        // Display the response
                        view.Text = responseString;
                    }
                    else
                        view.Text = "Something is wrong. Please try again later!";
                }
                else
                    MessageBox.Show("What is your url, mate?", "Ec o ec");
        }
    }
}