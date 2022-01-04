using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Robot.Classes {
    class Escenari : Grid {
        private int columnes;
        private int files;

        private int tresorX;
        private int tresorY;

        public Random rng;
        
        public Robot robot;
        Image tresorImg;

        public Escenari(int fil, int col) {
            columnes = col;
            files = fil;

            rng = new Random();


            for (int fila = 0; fila < files; fila++) {
                RowDefinitions.Add(new RowDefinition());
            }

            for (int column = 0; column < columnes; column++) {
                ColumnDefinitions.Add(new ColumnDefinition());
            }


            tresorX = 2;//rng.Next(columnes);
            tresorY = 2;//rng.Next(files);

            tresorImg = new Image();


            tresorImg.Source = new BitmapImage(new Uri("/Robot;component/Imatges/tresor.png",UriKind.Relative));
            
            
            
            tresorImg.SetValue(Grid.RowProperty, tresorY);
            tresorImg.SetValue(Grid.ColumnProperty, tresorX);

            this.Children.Add(tresorImg);

            this.ShowGridLines = true;


            robot = new Robot(3, 3);
            robot.SetValue(Grid.RowProperty, robot.PosX);
            robot.SetValue(Grid.ColumnProperty, robot.PosY);
             
            Children.Add(robot);
        }

        internal void Mou() {
            robot.Mou(this);
        }

        public bool PosValida(int x, int y) {
            return x >= 0 && y >= 0 && x < columnes && y < files; //&& !(x == tresorX && y == tresorY);
        }
    }
}
