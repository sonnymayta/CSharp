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

namespace InterfacesGraficas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            Content = grid;
            Button button = new Button();
            //button.Width = 120;
            //button.Height = 50;
            //button.Content = "Hola";
            WrapPanel wrapPanel = new WrapPanel();
            TextBox textBox1 = new TextBox();
            textBox1.Text = "Click";
            wrapPanel.Children.Add(textBox1);
            TextBox textBox2 = new TextBox();
            textBox2.Text = "Click";
            wrapPanel.Children.Add(textBox2);
            TextBox textBox3 = new TextBox();
            textBox3.Text = "Click";
            wrapPanel.Children.Add(textBox3);
            button.Content = wrapPanel;
            grid.Children.Add(button);
        }
    }
}