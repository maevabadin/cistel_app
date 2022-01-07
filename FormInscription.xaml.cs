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
    /// Logique d'interaction pour FormInscription.xaml
    /// </summary>
    public partial class FormInscription : Window
    {
        public FormInscription()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            MainWindow accueil = new MainWindow();
            accueil.Show();
            this.Close();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
