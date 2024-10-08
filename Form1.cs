using Newtonsoft.Json;
using System.Text;


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
            initializeDataGridView();
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


                        // Null check to ensure weather data exists
                        if (weatherData?.Main == null || weatherData.Weather == null || weatherData.Weather.Count == 0)
                        {
                            MessageBox.Show("Weather data is unavailable.");
                            
                        }



                        double tempInCelsius = weatherData.Main.temp - 273.15;
                        double tempInFahrenheit = (weatherData.Main.temp - 273.15) * 9 / 5 + 32;
                        double latitude = weatherData.Coord.lat;
                        double longitude = weatherData.Coord.lon;

                        //process the data 

                        currentTempLabel.Text = $"{tempInCelsius:0.00} �C / {tempInFahrenheit:0.00} �F";
                        locationLabel.Text = searchTerm;
                        searchTextBox.Text = searchTerm;
                        currentConditionLabel.Text = weatherData.Weather[0].description;

                        //gets the 7-day forecast using longitude and latitude
                       await Get5DayForcast(latitude, longitude);
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

        private DateTime TimeStampToDateTime(long timeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(timeStamp).ToLocalTime();
            return dtDateTime;
        }

        private async Task Get5DayForcast(double lat, double lon)
        {
            string apiKey = "c5bd03a941238a627959a47a8177f59d";
            //string forecastUrl = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={apiKey}&units=metric\r\n";
            string forecastUrl = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //sends GET rewuest for the forecast (7 days)
                    HttpResponseMessage responseMessage = await client.GetAsync(forecastUrl);

                    
                   


                    if (!responseMessage.IsSuccessStatusCode)
                    {
                        // If the response is not successful, display the error message
                        string errorMsg = await responseMessage.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error fetching forecast: {responseMessage.StatusCode}\n{errorMsg}");
                       // return; // Exit the method if there's an error
                    }



                    if (responseMessage.IsSuccessStatusCode)
                    {

                        string fData = await responseMessage.Content.ReadAsStringAsync();


                        if (string.IsNullOrEmpty(fData))
                        {
                            MessageBox.Show("Error: Received empty data from the API.");
                            return;
                        }

                        // Deserialize the forecast data
                        ForecastData forecastData = JsonConvert.DeserializeObject<ForecastData>(fData);

                        if (forecastData == null || forecastData.List == null || forecastData.List.Count == 0)
                        {
                            MessageBox.Show("No forecast data available.");
                            return;
                        }

                        // Prepare the forecast data for display in the data grid view
                        var forecastList = forecastData.List
                            .GroupBy(f => TimeStampToDateTime(f.Dt).Date)
                            .Select(g => new ForecastDisplay
                            {
                                date = g.Key.ToString("dd-MM-yyyy"),
                                temperature = $"{g.Average(f => f.Main.temp):0.00} �C",
                                condition = g.First().Weather[0].description,
                                humidity = $"{g.Average(f => f.Main.humidity):0.00} %",
                                windSpeed = $"{g.Average(f => f.Wind.speed):0.00} m/s"
                            })
                            .Take(5)
                            .ToList();

                        // Debug: Check the contents of forecastList
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in forecastList)
                        {
                            sb.AppendLine($"Date: {item.date}, Temperature: {item.temperature}, Condition: {item.condition}, Humidity: {item.humidity}, WindSpeed: {item.windSpeed}");
                        }
                        MessageBox.Show(sb.ToString(), "Forecast Data");

                        //bind the forecast data to a data grid view
                        dataGridView1.DataSource = forecastList;
                        dataGridView1.Refresh();

                        
                    }
                    else
                    {
                        MessageBox.Show("Error fetching the 5-day forecast");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occurred: {ex.Message}");
                    MessageBox.Show($"Error: {ex.Message}");
                }                   

            }

        }

        private void initializeDataGridView()
        {
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "Date";
            dataGridView1.Columns[1].Name = "Temperature";
            dataGridView1.Columns[2].Name = "Condition";
            dataGridView1.Columns[3].Name = "Humidity";
            dataGridView1.Columns[4].Name = "Wind Speed";
        }

    }
}
