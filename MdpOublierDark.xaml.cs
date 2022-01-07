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
    /// Logique d'interaction pour MdpOublierDark.xaml
    /// </summary>
    public partial class MdpOublierDark : Window
    {
        public MdpOublierDark()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            FormConnexionDark formConnexionDark = new FormConnexionDark();
            formConnexionDark.Show();
            this.Close();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
