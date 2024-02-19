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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listPob = new List<Poblaciones>();

            listPob.Add(new Poblaciones() { Poblacion1="Madrid", Poblacion2="Barcelona", Temperatura1=15, Temperatura2=17, DiferenciaTemperatura=12}); 
            listPob.Add(new Poblaciones() { Poblacion1="Madrid", Poblacion2="Barcelona", Temperatura1=15, Temperatura2=17, DiferenciaTemperatura = 42 }); 
            listPob.Add(new Poblaciones() { Poblacion1="Madrid", Poblacion2="Barcelona", Temperatura1=15, Temperatura2=17, DiferenciaTemperatura = 22 }); 

            listaPoblaciones.ItemsSource = listPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                string p1 = (listaPoblaciones.SelectedItem as Poblaciones).Poblacion1;
                string t1 = ((listaPoblaciones.SelectedItem as Poblaciones).Temperatura1).ToString();
                string p2 = (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2;
                string t2 = ((listaPoblaciones.SelectedItem as Poblaciones).Temperatura2).ToString();
                MessageBox.Show($"{p1} {t1} {p2} {t2}");
            }
            else
            {
                MessageBox.Show("Selecciona un elemento.");
            }
            
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                string p1 = (listaPoblaciones.SelectedItem as Poblaciones).Poblacion1;
                string t1 = ((listaPoblaciones.SelectedItem as Poblaciones).Temperatura1).ToString();
                string p2 = (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2;
                string t2 = ((listaPoblaciones.SelectedItem as Poblaciones).Temperatura2).ToString();
                MessageBox.Show($"{p1} {t1} {p2} {t2}");
            }
        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaTemperatura { get; set; }
    }
}