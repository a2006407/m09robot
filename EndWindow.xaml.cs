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

namespace Robot {
    /// <summary>
    /// Lógica de interacción para EndWindow.xaml
    /// </summary>
    public partial class EndWindow : Window {
        public EndWindow(int temps, int moviments, int canvisdeDir) {
            InitializeComponent();

            TBtemps.Text = temps.ToString();
            TBmov.Text = moviments.ToString();
            TBcandir.Text = canvisdeDir.ToString();

        }
    }
}
