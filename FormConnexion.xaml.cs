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
    /// Logique d'interaction pour FormConnexion.xaml
    /// </summary>
    public partial class FormConnexion : Window
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            MainWindow accueil = new MainWindow();
            accueil.Show();
            this.Close();
        }

        private void Mdp_Click(object sender, RoutedEventArgs e)
        {
            mdpOublier mdpOublier = new mdpOublier();
            mdpOublier.Show();
            this.Close();
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }
    }
}
