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
        // Creando mi dependency property (Su uso no es muy común)
        public int MiProperty
        {
            get { return (int)GetValue(miDependencyProperty); }
            set { SetValue(miDependencyProperty, value); }
        }

        public static readonly DependencyProperty miDependencyProperty = DependencyProperty.Register("MiProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();

            //Grid grid = new Grid();
            //Content = grid;
            //Button button = new Button();
            //button.Width = 200;
            //button.Height = 50;
            //button.Background = Brushes.Blue;
            //WrapPanel wrapPanel = new WrapPanel();            
            //TextBlock textBlock1 = new TextBlock();
            //textBlock1.Text = "Hola";
            //wrapPanel.Children.Add(textBlock1);
            //TextBlock textBlock2 = new TextBlock();
            //textBlock2.Text = "Click";
            //wrapPanel.Children.Add(textBlock2);
            //TextBlock textBlock3 = new TextBlock();
            //textBlock3.Background = Brushes.Red;
            //textBlock3.Foreground = Brushes.Green;
            //textBlock3.Text = "Enviar";
            //wrapPanel.Children.Add(textBlock3);
            //button.Content = wrapPanel;
            //grid.Children.Add(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Le has dado al botón de nuevo.");
            Console.WriteLine("Le has dado al botón.");
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al panel.");
        }

        private void Panel2_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        /*
         * EVENTOS DE TIPO BUBBLING
         * El evento se propaga hacia arriba
         * - window
         * - - stack
         * - - - boton (El evento se propagara hacia arriba hasta window)
         * - - - - texto del boton 
         * 
         * * EVENTOS DE TIPO TUNNELING
         * El evento se propaga hacia abajo (simpre con "preview" delante del nombre del evento)
         * - window
         * - - stack
         * - - - boton (El evento se propagara hacia Abajo hasta texto del boton)
         * - - - - texto del boton 
         * 
         * EVENTO DIRECTO 
         * Sin propagación
         * 
         * DATA BINDING
         * Tipos:
         * - oneWay
         * - oneWayToSource
         * - twoWays
         * - oneTime
         */
    }
}