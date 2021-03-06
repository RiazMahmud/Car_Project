﻿using System;
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
        public int x = 350;
        public int y = 300;
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
            if (key == 'u' && y != 120)
            {
                y = y -  3;    
            }
            else if (key == 'd' && y != 300)
            {
                y = y + 3;
            }
            else if (key == 'l'&&x!=50)
            {
                x = x - 3;
            }
            else if (key == 'r'&&x!=950 )
            {
                x = x + 3;
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
