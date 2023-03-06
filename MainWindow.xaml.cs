using System;
using System.Collections.Generic;
using System.Linq;
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
using RestApiApp_Pers.Models;

namespace RestApiApp_Pers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await LoadImage();
        }

        private async Task LoadImage()
        {
            PersModel persModel = await PersProcessor.LoadPers(int.Parse(txb.Text));

            Uri uri = new Uri(persModel.Image);
            image.Source = new BitmapImage(uri);

            lblName.Content = persModel.Name;
            lblLocation.Content = persModel.Location.Name;
            lblSpecies.Content = persModel.Species;
        }
    }
}
