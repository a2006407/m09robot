using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
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

        private int posX;
        private int posY;

        public Image img = new Image();

        public int PosX { get => posX; set {
                posX = value;
                this.SetValue(Grid.RowProperty, posX);
            }
        }
        public int PosY { get => posY; set {
                posY = value;
                this.SetValue(Grid.ColumnProperty, posY);
            }
        }

        public Robot(int posX, int posY) {
            this.PosX = posX;
            this.PosY = posY;
            img.Source = new BitmapImage(new Uri("/Robot;component/Imatges/robot.jpg",UriKind.Relative));

            BitmapImage bmpImg = new BitmapImage();

            bmpImg.BeginInit();

            bmpImg.UriSource = new Uri("../../../Imatges/arrow.png",UriKind.Relative);

            bmpImg.EndInit();

            TransformedBitmap tranformBmp = new TransformedBitmap();

            tranformBmp.BeginInit();

            tranformBmp.Source = bmpImg;

            RotateTransform r = new RotateTransform(90);

            tranformBmp.Transform = r;

            tranformBmp.EndInit();

            Image arrow = new Image();
            arrow.Source = tranformBmp;



            Grid g = new Grid();
            g.Children.Add(img);
            g.Children.Add(arrow);

            Content = g;
        }


        public void Mou(Escenari esc) {
            int rndInt = esc.rng.Next(5);
            if (rndInt <= 2) {
                switch (dir) {
                    case Direcio.Nord:
                        if (esc.PosValida(PosX, PosY - 1))
                            PosY -= 1;
                        break;
                    case Direcio.Sud:
                        if (esc.PosValida(PosX, PosY + 1))
                            PosY += 1;
                        break;
                    case Direcio.Est:
                        if (esc.PosValida(PosX - 1, PosY))
                            this.PosX -= 1; 
                        break;
                    case Direcio.Oest:
                        if (esc.PosValida(PosX + 1, PosY))
                            this.PosX += 1;
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
