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

namespace Robot {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Escenari esc;
        public MainWindow() {
            InitializeComponent();
            esc = new Escenari(2,2);
            mainGrid.Children.Add(esc);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (esc.Mou()) {
                EndWindow endW = new EndWindow(0, esc.robot.nmov, esc.robot.ndir);
                endW.ShowDialog();
            }
                
        }
    }
}
