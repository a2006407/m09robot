using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Classes {
    enum Direcio {
        Nord,//adalt
        Sud,//abaix
        Est,//dreta
        Oest//esquerra
    }
    class Robot {


        Direcio dir;

        private int posX;
        private int posY;

        public Robot(int posX, int posY) {
            this.posX = posX;
            this.posY = posY;
        }


        public void Mou(Random rng) {
            int rndInt = rng.Next(5);
            if (rndInt <= 2) {
                //endavant
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
