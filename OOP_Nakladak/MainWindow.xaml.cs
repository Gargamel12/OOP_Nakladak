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

            Tatra = new Nakladak(10000, 1300 , 30);
            Tatra.Znacka = "Tatra";
            
            Zetor = new Nakladak(10000, 1100, 32);
            Zetor.Znacka = "Zetor";

            Vypis();

        }
        public void Vypis()
        {
            kamion1.Text = Tatra.Znacka + "\n";
            kamion1.Text += "Nosnost" + " " + Tatra.Nosnost + "\n";
            kamion1.Text += "Naložení" + " " + Tatra.Nalozeno + "\n";
            kamion1.Text += "Spotreba" + " " + Tatra.Spotreba + "\n";
            kamion1.Text += "ObjemNadrze" + " " + Tatra.ObjemNadrz + "\n";
            kamion1.Text += "Palivo" + " " + Tatra.Palivo + "\n";
            kamion1.Text += "Vzdálenost" + " " + Tatra.Vzdalenost + "\n";

            kamion2.Text = Zetor.Znacka + "\n";
            kamion2.Text += "Nosnost" + " " + Zetor.Nosnost + "\n";
            kamion2.Text += "Naložení" + " " + Zetor.Nalozeno + "\n";
            kamion2.Text += "Spotreba" + " " + Zetor.Spotreba + "\n";
            kamion2.Text += "ObjemNadrze" + " " + Zetor.ObjemNadrz + "\n";
            kamion2.Text += "Palivo" + " " + Zetor.Palivo + "\n";
            kamion2.Text += "Vzdálenost" + " " + Zetor.Vzdalenost + "\n";
        }



        private void Nacepovat_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Tankovat(int.Parse(input1.Text)); 
            Vypis();
        }
        private void Nacepovat2_Click(object sender, RoutedEventArgs e)
        {
            Zetor.Tankovat(int.Parse(input2.Text));
            Vypis();
        }


        private void Jet_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Jet(int.Parse(input1.Text));
            Vypis();
        }

        private void Nalozit_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Naloz(int.Parse(input1.Text));
            Vypis();
        }

        private void Vylozit2_Click(object sender, RoutedEventArgs e)
        {
            Zetor.Vyloz(int.Parse(input2.Text));
            Vypis();
        }

        private void Vylozit_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Vyloz(int.Parse(input1.Text));
            Vypis();
        }

        private void Nalozit2_Click(object sender, RoutedEventArgs e)
        {
            Zetor.Naloz(int.Parse(input2.Text));
            Vypis();
        }

        private void Jet2_Click(object sender, RoutedEventArgs e)
        {
            Zetor.Jet(int.Parse(input2.Text));
            Vypis();
        }
    }
}
