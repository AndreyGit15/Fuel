using System.Windows;

namespace Fuel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        int defaultStorage = 175;
        private void CalculateFuel_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int inputVolume = int.Parse(InputVolumeFuel.Text);
                int inputDensity = int.Parse(InputDensityFuel.Text);
                var fuel = new Models.Fuel(inputVolume, inputDensity);
                OutputWeightFuel.Text = fuel.CalculateWeight().ToString();



            }
            catch (System.Exception)
            {
                MessageBox.Show("Ты где то не прав");
                throw;
            }

        }

        private void CalculateStorage_Click(object sender, RoutedEventArgs e)
        {
            var storage = new Models.Storage(defaultStorage);
            StorageVolume.Text = storage.CalculateStorage().ToString();
        }

        private void CalculateRefuel_Click(object sender, RoutedEventArgs e)
        {
            var storage = new Models.Storage(defaultStorage);
            int calculateStorage = storage.CalculateStorage();
            int calculateRefuel = int.Parse(InputRefuel.Text);
            var fuelStation = new Models.FuelStation(calculateStorage, calculateRefuel);
            StorageVolume.Text = fuelStation.CalculateStorage().ToString();
            defaultStorage = fuelStation.CalculateStorage();

        }

        private void CalculateRefuelNew_Click(object sender, RoutedEventArgs e)
        {
            int storageNew = int.Parse(InputRefuelNew.Text) + defaultStorage;
            defaultStorage = storageNew;
            var storage = new Models.Storage(defaultStorage);
            StorageVolume.Text = storage.CalculateStorage().ToString();
        }
    }
}
