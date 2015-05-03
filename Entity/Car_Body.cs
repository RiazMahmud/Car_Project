using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace Entity
{
    public class Car_Body
    {
        int f = 0;
        public void carRight(Graphics g)
        {

            Pen p = new Pen(Color.Black, 3);
            Pen p6 = new Pen(Color.Black, 3);
            Pen p4 = new Pen(Color.Gold, 3);
            Pen p5 = new Pen(Color.DarkOrange, 3);
            Pen p3 = new Pen(Color.Black, 8);
            Pen p1 = new Pen(Color.Red, 10);
            Pen p2 = new Pen(Color.Red, 3);
            Pen p7 = new Pen(Color.Black, 30);
            Pen p8 = new Pen(Color.Gold, 10);
            Pen p9 = new Pen(Color.Blue, 1);
            
            Pen bluepen = new Pen(Color.Black, 3);

            //front
            g.DrawLine(p, 12+110, 60, 52+112, 60);
            g.DrawLine(p1, 12+110, 66, 46+110, 66);

            g.DrawLine(p, 30, 60, 12 + 110, 60);
            g.DrawLine(p1, 35, 66, 12 + 110, 66);
            g.DrawLine(p2, 30, 60, 35, 70);
            g.DrawLine(p2, 32, 60, 35, 70);
            g.DrawLine(p2, 35, 70, 27, 100);
            g.DrawLine(p2, 27, 100, 33, 105);
            g.DrawLine(p2, 33, 105, 22, 114);
            g.DrawLine(p2, 22, 113, 21, 166);

            g.DrawLine(p, 52+110, 60, 87+110, 62);
            g.DrawLine(p1, 12 + 110, 66, 46 + 110, 66);
            g.DrawLine(p, 87+110, 63, 112+110, 68);
            g.DrawLine(p1, 110 + 43, 65, 46 + 130, 66);
            g.DrawLine(p, 112+108, 69, 152+110, 105);
            g.DrawLine(p1, 46+130, 66, 46 + 170, 72);
            g.DrawLine(p1, 46 + 168, 72, 46 + 190, 90);
            g.DrawLine(p1, 46 + 188, 88, 46 + 212, 109);
            g.DrawLine(p1, 46 + 210, 109, 46 + 266, 130);
            g.DrawLine(p1, 46 + 264, 130, 46 + 266, 140);
            g.DrawLine(p, 152+110, 105,200+110, 123);
            //g.DrawLine(p3, 294, 68, 305, 100);

            g.DrawLine(p, 200+110, 123, 207+110, 135);
            g.DrawLine(p2, 207+110, 135, 200+110, 145);
            g.DrawLine(p2, 200+110, 135, 207+110, 160);

            g.DrawLine(p2, 207+110, 160, 207+110, 170);
            g.DrawLine(p2, 207 + 110, 170, 207 + 65, 168);
            g.DrawLine(p8, 32, 118, 251, 118);
            g.DrawLine(p2, 48, 167, 20, 165);
            g.DrawLine(p2, 72, 165, 250, 165);
            
            g.DrawLine(p1, 74, 155, 250, 155);

            g.DrawLine(p7, 125-85, 90, 170-85, 90);

            g.DrawLine(p7, 180-85, 90, 230-85, 90);

            g.DrawLine(p7, 240-85, 90, 290-95, 90);
            //g.DrawLine(p3, 290 - 97, 78, 290 - 70, 97);
            g.DrawLine(p3, 290 - 98, 79, 290 - 71, 99);
            g.DrawLine(p3, 290 - 100, 80, 290 - 70, 102);
            g.DrawLine(p3, 240 - 85, 94, 290 - 80, 94);
            g.DrawLine(p3, 240 - 85, 92, 290 - 80, 92);
            g.DrawLine(p3, 240 - 85, 102, 290 - 73, 102);

            g.DrawLine(p4, 34, 109, 251, 109);



            //wheelFront
            g.DrawEllipse(p, 50, 152, 23, 23);
            g.DrawEllipse(p5, 54, 156, 15, 15);
            g.DrawEllipse(p6, 58, 160, 8, 8);

            //wheelBack
            g.DrawEllipse(p, 251, 151, 23, 23);
            g.DrawEllipse(p5, 255, 155, 15, 15);
            g.DrawEllipse(p6, 259, 159, 8, 8);
            //headLight
            g.DrawEllipse(p6, 22+262, 140, 12, 15);
            g.DrawEllipse(p9, 22 + 265, 143, 7, 10);

        }


        public void carLeft(Graphics g)
        {
            Pen p = new Pen(Color.Black, 3);
            Pen p6 = new Pen(Color.Black, 3);
            Pen p4 = new Pen(Color.Gold, 3);
            Pen p5 = new Pen(Color.DarkOrange, 3);
            Pen p3 = new Pen(Color.Black, 8);
            Pen p1 = new Pen(Color.Red, 10);
            Pen p2 = new Pen(Color.Red, 3);
            Pen p7 = new Pen(Color.Black, 30);
            Pen p8 = new Pen(Color.Gold, 10);
            Pen p9 = new Pen(Color.Blue, 1);
            Pen bluepen = new Pen(Color.Black, 3);

            //front
            g.DrawLine(p, 160, 60, 300, 60);
            g.DrawLine(p1, 160, 66, 294, 66);

            g.DrawLine(p2, 300, 61, 290, 70);
            g.DrawLine(p2, 298, 61, 288, 68);
            g.DrawLine(p2, 296, 61, 286, 68);

            g.DrawLine(p2, 290, 70, 300, 100);
            //g.DrawLine(p3, 294, 68, 305, 100);

            g.DrawLine(p2, 301, 100, 295, 109);
            g.DrawLine(p2, 295, 109, 304, 118);
            g.DrawLine(p2, 304, 117, 305, 155);

            g.DrawLine(p2, 305, 155, 275, 160);

            //front
            g.DrawLine(p, 160, 60, 125, 63);
            g.DrawLine(p1, 160, 65, 125, 69);
            g.DrawLine(p, 125, 63, 100, 70);
            g.DrawLine(p1, 125, 68, 100, 76);

            //front
            g.DrawLine(p, 100, 70, 60, 105);
            g.DrawLine(p1, 102, 76, 63, 110);

            //front
            g.DrawLine(p, 60, 105, 12, 123);
            g.DrawLine(p1, 65, 110, 15, 128);


            g.DrawLine(p, 12, 123, 5, 135);
            g.DrawLine(p1, 16, 126, 9, 140);

            g.DrawLine(p2, 5, 135, 12, 145);

            g.DrawLine(p2, 12, 145, 5, 160);
            g.DrawLine(p2, 5, 160, 5, 170);

            g.DrawLine(p2, 5, 170, 50, 167);
            g.DrawLine(p2, 72, 165, 250, 165);
            g.DrawLine(p1, 74, 155, 250, 155);
            g.DrawLine(p4, 72, 109, 295, 109);
            g.DrawLine(p8, 72, 118, 295, 118);

            g.DrawLine(p7, 125, 90, 170, 90);
            g.DrawLine(p3, 130, 75, 103, 103);

            g.DrawLine(p3, 104, 101, 150, 101);
            g.DrawLine(p3, 114, 91, 150, 91);
            g.DrawLine(p3, 111, 95, 150, 95);
            g.DrawLine(p7, 180, 90, 230, 90);

            g.DrawLine(p7, 240, 90, 290, 90);




            //wheelFront
            g.DrawEllipse(p, 50, 152, 23, 23);
            g.DrawEllipse(p5, 54, 156, 15, 15);
            g.DrawEllipse(p6, 58, 160, 8, 8);

            //wheelBack
            g.DrawEllipse(p, 251, 151, 23, 23);
            g.DrawEllipse(p5, 255, 155, 15, 15);
            g.DrawEllipse(p6, 259, 159, 8, 8);
            //headLight
            g.DrawEllipse(p6, 22, 140, 12, 15);
            g.DrawEllipse(p9, 24, 142, 7, 10);


        }
        public void carUp(Graphics g)
        {

            Pen bluepen = new Pen(Color.Crimson, 3);
            Pen gold = new Pen(Color.Gold, 20);
            Pen black = new Pen(Color.Gray, 12);
            Pen light = new Pen(Color.Wheat, 2);
            Pen line = new Pen(Color.Gold, 1);
            //g.DrawLine(bluepen, 630, 391, 630, 491);

            //front
            g.DrawLine(bluepen, 135, 5, 175, 5);
            g.DrawLine(bluepen, 120, 40, 135, 5);
            g.DrawLine(bluepen, 190, 40, 175, 5);
            g.DrawLine(gold, 155, 20, 155, 30);
            //back
            g.DrawLine(bluepen, 135, 160, 175, 160);
            g.DrawLine(bluepen, 120, 140, 135, 160);
            g.DrawLine(bluepen, 190, 140, 175, 160);
            g.DrawLine(line, 127, 145, 182, 145);
            g.DrawLine(line, 133, 150, 177, 150);
            g.DrawLine(line, 135, 155, 175, 155);
            //midle body
            g.DrawLine(bluepen, 120, 40, 120, 140);
            g.DrawLine(bluepen, 190, 40, 190, 140);
            g.DrawLine(bluepen, 120, 40, 190, 40);
            g.DrawLine(bluepen, 120, 140, 190, 140);
            g.DrawLine(bluepen, 135, 60, 175, 60);
            g.DrawLine(bluepen, 120, 40, 135, 60);
            g.DrawLine(bluepen, 190, 40, 175, 60);
            g.DrawLine(bluepen, 135, 120, 175, 120);
            g.DrawLine(bluepen, 120, 140, 135, 120);
            g.DrawLine(bluepen, 190, 140, 175, 120);
            g.DrawLine(bluepen, 135, 60, 135, 120);
            g.DrawLine(bluepen, 175, 60, 175, 120);
            g.DrawLine(gold, 155, 80, 155, 100);
            g.DrawLine(black, 128, 60, 128, 120);
            g.DrawLine(black, 183, 60, 183, 120);

            //front left light
            g.DrawLine(light, 119, 40, 110, 47);
            g.DrawLine(light, 110, 47, 110, 52);
            g.DrawLine(light, 110, 52, 119, 52);
            //front right light
            g.DrawLine(light, 191, 40, 200, 47);
            g.DrawLine(light, 200, 47, 200, 52);
            g.DrawLine(light, 200, 52, 191, 52);

        }

        public void carDown(Graphics g)
        {
            Pen bluepen = new Pen(Color.Crimson, 3);
            Pen gold = new Pen(Color.Gold, 20);
            Pen black = new Pen(Color.Gray, 12);
            Pen light = new Pen(Color.Wheat, 2);
            Pen line = new Pen(Color.Gold, 1);
            //g.DrawLine(bluepen, 630, 391, 630, 491);


            //front
            g.DrawLine(bluepen, 135, 175, 175, 175);
            g.DrawLine(bluepen, 120, 140, 135, 175);
            g.DrawLine(bluepen, 190, 140, 175, 175);
            g.DrawLine(gold, 155, 160, 155, 150);

            //back
            g.DrawLine(bluepen, 135, 20, 175, 20);
            g.DrawLine(bluepen, 120, 40, 135, 20);
            g.DrawLine(bluepen, 190, 40, 175, 20);
            g.DrawLine(line, 133, 25, 177, 25);
            g.DrawLine(line, 131, 30, 179, 30);
            g.DrawLine(line, 129, 35, 181, 35);
            //midle body
            g.DrawLine(bluepen, 120, 40, 120, 140);
            g.DrawLine(bluepen, 190, 40, 190, 140);
            g.DrawLine(bluepen, 120, 40, 190, 40);
            g.DrawLine(bluepen, 120, 140, 190, 140);
            g.DrawLine(bluepen, 135, 60, 175, 60);
            g.DrawLine(bluepen, 120, 40, 135, 60);
            g.DrawLine(bluepen, 190, 40, 175, 60);
            g.DrawLine(bluepen, 135, 120, 175, 120);
            g.DrawLine(bluepen, 120, 140, 135, 120);
            g.DrawLine(bluepen, 190, 140, 175, 120);
            g.DrawLine(bluepen, 135, 60, 135, 120);
            g.DrawLine(bluepen, 175, 60, 175, 120);
            g.DrawLine(gold, 155, 80, 155, 100);
            g.DrawLine(black, 128, 60, 128, 120);
            g.DrawLine(black, 183, 60, 183, 120);

            //front left light
            g.DrawLine(light, 119, 140, 110, 133);
            g.DrawLine(light, 110, 133, 110, 128);
            g.DrawLine(light, 110, 128, 119, 128);
            //front right light
            g.DrawLine(light, 191, 140, 200, 133);
            g.DrawLine(light, 200, 133, 200, 128);
            g.DrawLine(light, 200, 128, 191, 128);
        }
        public void carRightSideLight(Graphics g)
        {
            Pen p = new Pen(Color.WhiteSmoke, 1);
            //light
            g.DrawLine(p, 292, 145, 400, 100);
            g.DrawLine(p, 292, 145, 400, 105);
            g.DrawLine(p, 292, 145, 400, 110);
            g.DrawLine(p, 292, 145, 400, 115);
            g.DrawLine(p, 292, 145, 400, 120);
            g.DrawLine(p, 292, 145, 400, 125);
            g.DrawLine(p, 292, 145, 400, 130);
            g.DrawLine(p, 292, 145, 400, 135);
            g.DrawLine(p, 292, 145, 400, 140);
            g.DrawLine(p, 292, 145, 400, 145);
            g.DrawLine(p, 292, 145, 400, 150);
            g.DrawLine(p, 292, 145, 400, 155);
            g.DrawLine(p, 292, 145, 400, 160);
            g.DrawLine(p, 292, 145, 400, 165);
            g.DrawLine(p, 292, 145, 400, 170);
        }
        public void carLeftSideLight(Graphics g)
        {
            Pen p = new Pen(Color.WhiteSmoke, 1);
           
            g.DrawLine(p, 30, 146,-2,100);
            g.DrawLine(p, 30, 146, -2, 105);
            g.DrawLine(p, 30, 146, -2, 110);
            g.DrawLine(p, 30, 146, -2, 115);
            g.DrawLine(p, 30, 146, -2, 120);
            g.DrawLine(p, 30, 146, -2, 125);
            g.DrawLine(p, 30, 146, -2, 130);
            g.DrawLine(p, 30, 146, -2, 135);
            g.DrawLine(p, 30, 146, -2, 140);
            g.DrawLine(p, 30, 146, -2, 145);
            g.DrawLine(p, 30, 146, -2, 150);
            g.DrawLine(p, 30, 146, -2, 155);
            g.DrawLine(p, 30, 146, 0, 160);
            //g.DrawLine(p, 30, 146, -2, );
            //g.DrawLine(p, 30, 146, -2, -20);
            //g.DrawLine(p, 30, 146, -10000, -1);
            
            

        }
    }
}
