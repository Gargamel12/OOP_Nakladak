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

namespace OOP_Nakladak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak Tatra;
        Nakladak Zetor;
        public MainWindow()
        {
            InitializeComponent();

            Tatra = new Nakladak(1000, 200 , 30);
            Tatra.Znacka = "Tatra";
            Zetor = new Nakladak(1000, 220, 32);
            Zetor.Znacka = "Zetor";

            kamion1.Text = Tatra.Znacka + "\n";
            kamion1.Text = "Nosnost" +  Tatra.Nosnost + "\n";
            kamion1.Text = "Naloženo" + Tatra.Nalozeno + "\n";
            kamion1.Text = "Objem Nádrž" + Tatra.ObjemNadrz + "\n";
            kamion1.Text = "Spotřeba" + Tatra.Spotreba + "\n";
            kamion1.Text = "Nosnost" + Tatra.Nosnost + "\n";






        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Naložit
        }
    }
}
