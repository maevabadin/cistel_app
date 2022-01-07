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
    /// Logique d'interaction pour FormConnexionDark.xaml
    /// </summary>
    public partial class FormConnexionDark : Window
    {
        public FormConnexionDark()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            WindowDark windowDark = new WindowDark();
            windowDark.Show();
            this.Close();
        }

        private void Mdp_Click(object sender, RoutedEventArgs e)
        {
            MdpOublierDark mdpOublierDark = new MdpOublierDark();
            mdpOublierDark.Show();
            this.Close();
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            AccueilDark accueilDark = new AccueilDark();
            accueilDark.Show();
            this.Close();
        }
    }
}
