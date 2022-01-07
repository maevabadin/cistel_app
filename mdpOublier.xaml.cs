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
    /// Logique d'interaction pour mdpOublier.xaml
    /// </summary>
    public partial class mdpOublier : Window
    {
        public mdpOublier()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.Show();
            this.Close();
        }
    }
}
