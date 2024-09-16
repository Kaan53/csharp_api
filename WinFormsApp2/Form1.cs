using Newtonsoft.Json.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://api.thecatapi.com/v1/images/search"; // �rnek API

            try
            {
                // API'den veri �ekme i�lemi
                var imageUrl = await FetchDataFromApi(apiUrl);
                txtData.Text = imageUrl; // Sadece URL'yi g�steriyoruz
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}");
            }
        }

        // API'den veri �eken fonksiyon
        private async Task<string> FetchDataFromApi(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();

                    // JSON verisini parse etme
                    JArray jsonArray = JArray.Parse(responseData);
                    string imageUrl = jsonArray[0]["url"].ToString(); // �lk kedi g�rselinin URL'si

                    return imageUrl;
                }
                else
                {
                    throw new Exception("API'den veri al�namad�.");
                }
            }
        }
    }
}
