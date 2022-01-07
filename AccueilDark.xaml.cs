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
using System.Windows.Shapes;

namespace cistel_elec_ge
{
    /// <summary>
    /// Logique d'interaction pour AccueilDark.xaml
    /// </summary>
    public partial class AccueilDark : Window
    {
        public AccueilDark()
        {
            InitializeComponent();
        }

        private void RédigerDevis_Click(object sender, RoutedEventArgs e)
        {
            InterfaceDark menu = new InterfaceDark();
            menu.Contenu.Source = new Uri("devis_et_facture_dark.xaml", UriKind.Relative);
            menu.Show();
            this.Close();
        }

        

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            InterfaceDark menu = new InterfaceDark();
            menu.Contenu.Source = new Uri("stockDark.xaml", UriKind.Relative);
            menu.Show();
            this.Close();
        }

        private void AjoutClients_Click(object sender, RoutedEventArgs e)
        {
            InterfaceDark menu = new InterfaceDark();
            menu.Contenu.Source = new Uri("formulaire_clientsDarkMode.xaml", UriKind.Relative);
            menu.Show();
            this.Close();
        }

        private void ListeClients_Click(object sender, RoutedEventArgs e)
        {
            InterfaceDark menu = new InterfaceDark();
            menu.Contenu.Source = new Uri("clientsDark.xaml", UriKind.Relative);
            menu.Show();
            this.Close();
        }

        private void ListeDevis_Click(object sender, RoutedEventArgs e)
        {
            InterfaceDark menu = new InterfaceDark();
            menu.Contenu.Source = new Uri("Liste_devis_facturesDark.xaml", UriKind.Relative);
            menu.Show();
            this.Close();
        }

        private void Light_Click(object sender, RoutedEventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void Rendezvous_Click(object sender, RoutedEventArgs e)
        {
            InterfaceDark menu = new InterfaceDark();
            menu.Contenu.Source = new Uri("RdvDark.xaml", UriKind.Relative);
            menu.Show();
            this.Close();
        }
    }
}
