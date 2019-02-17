using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace AdministratorClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static HttpClient client = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://localhost:9090");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Random rnd = new Random();
            int numberOfFares = rnd.Next(1, 13);
            for (int i = 0; i < numberOfFares; i++)
            {
                FaresListGrid.RowDefinitions.Add(new RowDefinition());
            }
            //put labels in grid
            Label l = new Label();
            FaresListGrid.Children.Add(l);
        }

        private void CreateDriverBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateDriverAsync();
        }

        private void CreateCarBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateCarAsync();
        }


        async void CreateDriverAsync()
        {
            try
            {
                Name name = new Name(DriverFirstName.Text, DriverLastName.Text);
                string driverEmail = DriverEmail.Text;
                string driverPassword = DriverPassword.Text;
                string driverPhone = DriverPhone.Text;
                string driverLicense = DriverLicense.Text;
                Driver driver = new Driver(name, driverLicense, driverEmail, driverPassword, driverPhone, false);
                HttpResponseMessage response = await client.PostAsJsonAsync("/admin/rest/driver/createDriver", driver);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(response.StatusCode);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the values in the correct format", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }   
        }

        async void CreateCarAsync()
        {
            try
            {
                int driverId = Convert.ToInt32(DriverId.Text);
                string carLicensePlate = CarLicensePlate.Text;
                double carPricePerKm = Convert.ToDouble(CarPricePerKm.Text);
                string carType = CarType.Text;
                string carModel = CarModel.Text;
                int carTrunkSize = Convert.ToInt32(CarTrunkSize.Text);
                int carNrOfSeats = Convert.ToInt32(CarNrOfSeats.Text);
                Car car = new Car(driverId, carLicensePlate, carPricePerKm, carType, carModel, carNrOfSeats, carTrunkSize);
                HttpResponseMessage response = await client.PostAsJsonAsync("/admin/rest/driver/createCar", car);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(response.StatusCode);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the values in the correct format", "Invalid Input", MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }
    }
}
