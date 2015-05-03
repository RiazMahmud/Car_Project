using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BO
{
    public class BoLayer
    {
        DalLayer d = new DalLayer();
        public int x = 72;
        public int y = 56;
        public char key = 'r';
        public bool saveSpeed(Car c)
        {
            return d.save(Convert.ToString(c.speed));
        }
        public int speedCalculation()
        {
            Car c = d.getData();
            if (c.speed == 10)
                return 1000;
            else if (c.speed == 20)
                return 650;
            else if (c.speed == 30)
                return 350;
            else if (c.speed == 40)
                return 250;
            else if (c.speed == 50)
                return 70;
            else if (c.speed == 60)
                return 40;
            else if (c.speed == 70)
                return 20;
            else if (c.speed == 80)
                return 10;
            else if (c.speed == 90)
                return 5;
            else if (c.speed == 100)
                return 1;
            else
                return 0;
        }

        public int getData()
        {
            Car c = d.getData();
            int speed = c.speed;
            return speed;
        }
        
        public void changeAxes(char key)
        {
            
            if (key == 'u' )
            {
               /* if (y > 565)
                {
                    y = y - 3;
                }*/
                if ((x+72 < 380 && y > 315) || (x > 690 && y < 350 && y > 48) || (y > 565))
                {

                    y = y - 3;
                }
                
                

               
            }
            else if (key == 'd')
            {
                
                if ((y < 71 || (x > 690 && y < 200)))
                {
                    y = y + 3;
                }
                else if ((y < 327 && y > 199) || (x < 305 && y > 320 && y < 577) || (y < 577 && y > 505 && x > 307) )
                {
                    y = y + 3;
                }
                    
            }
            else if (key == 'l')
            {
                
                if(x > 790)
                {
                    x = x - 3;
                   
                }
                else if ((x > 63 && y < 75) ||(x > 63 && y > 260))
                {
                    x = x - 3;
                }
               
            }
            else if (key == 'r')
            {
                int c = 0;
                if(x < 194)
                {
                    x = x + 3;
                }
                else if ((x < 950 && y < 75) || (x < 950 && y > 510) || ( x < 950 && y <333))
                {
                    x = x + 3;
                }
               
            }
        }
        public void setKey(char c)
        {
            key = 'c';
        }
        public char getKey()
        {
            return key;
        }
    }
}
