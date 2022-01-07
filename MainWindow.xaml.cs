using Robot.Classes;
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
using System.Windows.Threading;

namespace Robot {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Escenari esc;
        DispatcherTimer rellotje;
        public MainWindow() {
            InitializeComponent();
            esc = new Escenari(2,2);
            mainGrid.Children.Add(esc);
            rellotje = new DispatcherTimer();

            rellotje.Tick += Rellotje_Tick;

        }

        private void Rellotje_Tick(object sender, EventArgs e) {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (esc.Mou()) {
                EndWindow endW = new EndWindow(0, esc.robot.nmov, esc.robot.ndir);
                endW.ShowDialog();
            }
                
        }
    }
}
