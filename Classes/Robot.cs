using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Robot.Classes {
    enum Direcio {
        Nord,//adalt
        Sud,//abaix
        Est,//dreta
        Oest//esquerra
    }
    class Robot : UserControl {


        Direcio dir;

        public int posX;
        public int posY;

        public Image img = new Image();

        public Robot(int posX, int posY) {
            this.posX = posX;
            this.posY = posY;
            img.Source = new BitmapImage(new Uri("/Robot;component/Imatges/robot.jpg",UriKind.Relative));
            Content = img;
        }


        public void Mou(Escenari esc) {
            int rndInt = esc.rng.Next(5);
            if (rndInt <= 2) {
                switch (dir) {
                    case Direcio.Nord:
                        esc.PosValida(posX, posY-1);
                        break;
                    case Direcio.Sud:
                        esc.PosValida(posX, posY+1);
                        break;
                    case Direcio.Est:
                        esc.PosValida(posX -1, posY);
                        break;
                    case Direcio.Oest:
                        esc.PosValida(posX + 1, posY);
                        break;
                    default:
                        break;
                }
            } else {
                switch (dir) {
                    case Direcio.Nord:
                        if (rndInt == 3)
                            dir = Direcio.Sud;
                        else
                            dir = Direcio.Est;
                        break;
                    case Direcio.Sud:
                        if (rndInt == 3)
                            dir = Direcio.Est;
                        else
                            dir = Direcio.Oest;
                        break;
                    case Direcio.Est:
                        if (rndInt == 3)
                            dir = Direcio.Nord;
                        else
                            dir = Direcio.Sud;
                        break;
                    case Direcio.Oest:
                        if (rndInt == 3)
                            dir = Direcio.Nord;
                        else
                            dir = Direcio.Sud;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
