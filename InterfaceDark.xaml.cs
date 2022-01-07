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
    /// Logique d'interaction pour InterfaceDark.xaml
    /// </summary>
    public partial class InterfaceDark : Window
    {
        public InterfaceDark()
        {
            InitializeComponent();
        }

        private void RédigerDevis_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("devis_et_facture_dark.xaml", UriKind.Relative);
        }

        private void ListeDevis_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("Liste_devis_facturesDark.xaml", UriKind.Relative);
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("stockDark.xaml", UriKind.Relative);
        }

        private void ListeClients_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("clientsDark.xaml", UriKind.Relative);
        }

        private void AjoutClient_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("formulaire_clientsDarkMode.xaml", UriKind.Relative);
        }

        private void Light_Click(object sender, RoutedEventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void Rendezvous_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("RdvDark.xaml", UriKind.Relative);
        }
    }
}
