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
        int time = 0;
        bool running = false;
        public MainWindow(int f, int c) {
            InitializeComponent();
            esc = new Escenari(f,c);
            mainGrid.Children.Add(esc);
            rellotje = new DispatcherTimer();

            rellotje.Tick += Rellotje_Tick;

            rellotje.Interval = TimeSpan.FromMilliseconds(100);
            rellotje.Start();
        }

        private void Rellotje_Tick(object sender, EventArgs e) {
            time++;
            Mou();
        }


        private void Button_Click(object sender, RoutedEventArgs e) {
            if (esc.Mou()) {
                EndWindow endW = new EndWindow(0, esc.robot.nmov, esc.robot.ndir);
                endW.ShowDialog();
                rellotje.Stop();
            }
        }

        private void Mou() {
            if (running) {
                if (esc.Mou()) {
                    EndWindow endW = new EndWindow(0, esc.robot.nmov, esc.robot.ndir);
                    endW.ShowDialog();
                    rellotje.Stop();
                }
            }
        }

        private void Run(object sender, RoutedEventArgs e) {
            running = true;
        }
        private void Stop(object sender, RoutedEventArgs e) {
            running = false;
        }
    }
}
