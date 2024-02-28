using System.Text;
using System.Text.Json;
namespace Lab4_Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        // Instantiate HttpClient once and re-used throughout the life of an application.
        private readonly HttpClient client = new HttpClient();

        private async void btnPost_Click(object sender, EventArgs e)
        {
            // Get the url from text box
            string url = getUrl.Text.Trim();
            // Get the post info and convert into a JSON string
            string json = JsonSerializer.Serialize(post_value.Text.Trim());
            // Convert string into HTTP content
            StringContent content = new StringContent(json, Encoding.UTF8);
            // Send a POST request to the url above as an asynchronous operation.
            HttpResponseMessage responseMess = await client.PostAsync(url, content);
            // Serialize the HTTP content to a string as an asynchronous operation.
            string response = responseMess.Content.ReadAsStringAsync().Result;
            // Display the response
            view.Text = response;
        }
    }
}