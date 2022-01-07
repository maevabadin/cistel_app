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
    /// Logique d'interaction pour Interface.xaml
    /// </summary>
    public partial class Interface : Window
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("stock.xaml", UriKind.Relative);
        }

        private void ListeClients_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("clientsLight.xaml", UriKind.Relative);
        }

        private void AjoutClient_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("formulaire_clients.xaml", UriKind.Relative);
        }

        private void RédigerDevis_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("devis_et_facture_light.xaml", UriKind.Relative);
        }

        private void ListeDevis_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("Liste_devis_factures.xaml", UriKind.Relative);

        }

        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            AccueilDark accueil = new AccueilDark();
            accueil.Show();
            this.Close();
        }

        private void Rendezvous_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Source = new Uri("Rdv.xaml", UriKind.Relative);
        }
    }
}
