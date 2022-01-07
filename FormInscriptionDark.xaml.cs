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
    /// Logique d'interaction pour FormInscriptionDark.xaml
    /// </summary>
    public partial class FormInscriptionDark : Window
    {
        public FormInscriptionDark()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            WindowDark windowDark = new WindowDark();
            windowDark.Show();
            this.Close();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
