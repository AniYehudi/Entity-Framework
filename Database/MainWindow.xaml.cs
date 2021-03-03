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

namespace Database
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Views.Angajati ang = new Views.Angajati();
            this.Hide();
            ang.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Views.Clienti cli = new Views.Clienti();
            this.Hide();
            cli.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Views.Furnizori frn = new Views.Furnizori();
            this.Hide();
            frn.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Views.Inventar inv = new Views.Inventar();
            this.Hide();
            inv.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Views.Produse pro = new Views.Produse();
            this.Hide();
            pro.Show();
        }
    }
}
