using Newtonsoft.Json;


namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            FetchDataFromApi(search);
        }


        private async void FetchDataFromApi(string searchTerm)
        {
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={searchTerm}&appid=c5bd03a941238a627959a47a8177f59d";
            

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //sends GET request to the api with the search term
                    HttpResponseMessage responseMessage = await client.GetAsync(apiUrl);

                    //checks if the response was successful
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        string data = await responseMessage.Content.ReadAsStringAsync();

                        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(data);

                        temperatureLabel.Text = $"{weatherData.Main.temp} K";
                        descriptionLabel.Text = weatherData.Weather[0].description;
                        windSpeedLabel.Text = $"{weatherData.Wind.speed} m/s";
                        //process the data 
                        //searchTextBox.Text = $"Location: {weatherData.Name}\n" +
                        //              $"Temperature: {weatherData.Main.Temp - 273.15:0.0} °C\n" +
                        //              $"Weather: {weatherData.Weather[0].Description}\n" +
                        //              $"Humidity: {weatherData.Main.Humidity}%\n" +
                        //              $"Wind Speed: {weatherData.Wind.Speed} m/s"; ;
                        searchTextBox.Text = searchTerm;
                        //searchTerm = searchTextBox.Text;

                    }
                    else
                    {
                        MessageBox.Show("Error: could not fetch data from api");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occured");
                }
            }
        }

    }
}
