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

namespace cistel_elec_ge
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.Show();
            this.Close();
        }

        private void Inscription_Click(object sender, RoutedEventArgs e)
        {
            FormInscription formInscription = new FormInscription();
            formInscription.Show();
            this.Close();
        }

        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            WindowDark accueil = new WindowDark();
            accueil.Show();
            this.Close();
        }
    }
}
