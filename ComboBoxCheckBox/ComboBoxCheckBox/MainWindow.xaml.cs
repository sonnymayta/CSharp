using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxCheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();
            ListaCapitales.Add(new Capitales() { NombreCapital = "Capital 1"});
            ListaCapitales.Add(new Capitales() { NombreCapital = "Capital 2"});
            ListaCapitales.Add(new Capitales() { NombreCapital = "Capital 3"});
            ListaCapitales.Add(new Capitales() { NombreCapital = "Capital 4"});

            Capitales.ItemsSource = ListaCapitales;
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            Capital1.IsChecked = true;
            Capital2.IsChecked = true;
            Capital3.IsChecked = true;
            Capital4.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            Capital1.IsChecked = false;
            Capital2.IsChecked = false;
            Capital3.IsChecked = false;
            Capital4.IsChecked = false;
        }

        private void IndividualChecked(object sender, RoutedEventArgs e)
        {
            if (Capital1.IsChecked == true && Capital2.IsChecked == true && Capital3.IsChecked == true && Capital4.IsChecked == true)
            {
                TodasC.IsChecked = true;
            } 
            else
            {
                TodasC.IsChecked = null;
            }
        }

        private void IndividualNoChecked(object sender, RoutedEventArgs e)
        {
            if (Capital1.IsChecked == false && Capital2.IsChecked == false && Capital3.IsChecked == false && Capital4.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}