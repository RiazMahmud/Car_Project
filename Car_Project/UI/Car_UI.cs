using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public partial class Car_UI : Form
    {
        BoLayer bl = new BoLayer();
        Graphics g;
        Char keyPress;
        int x;
        int y;
       
        Car_Body c = new Car_Body();
        public Car_UI()
        {
            InitializeComponent();
            g = carPanel.CreateGraphics();
            int x = bl.x;
            int y = bl.y;
            keyPress = 'r';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentInfoLabel.Text = Convert.ToString(bl.getData());
        }
        private void startButton_Click(object sender, EventArgs e)
        {
          
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            
        }
        private void speedButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(speedBox.Text))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(speedBox.Text);
                if (bl.saveSpeed(c))
                {
                    currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bl.changeAxes(keyPress);
            carPanel.Location = new Point(bl.x, bl.y);
            
        }
        
       
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                g.Clear(Color.DarkSlateGray);
                c.carUp(g);  
            }
            else if (e.KeyCode == Keys.Down)
            {            
                keyPress = 'd';
                g.Clear(Color.DarkSlateGray);
                c.carDown(g);
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                g.Clear(Color.DarkSlateGray);
                c.carLeft(g);
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                g.Clear(Color.DarkSlateGray);
                c.carRight(g);
            }
            else if (e.KeyCode == Keys.H)
            {
                try
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = "C:\\Sound\\vehicle043.wav";

                    player.Load();
                    player.PlaySync();
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.KeyCode == Keys.L )
            {
                c.carRightSideLight(g);

            }
            else if (e.KeyCode == Keys.K)
            {
                c.carLeftSideLight(g);
            }
            else if (e.KeyCode == Keys.S)
            {
                c.carRight(g);

                if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(currentInfoLabel.Text))
                {
                    timer1.Interval = bl.speedCalculation();
                    timer1.Start();
                }
            }
            else if (e.KeyCode == Keys.B)
            {
                timer1.Stop();
            }
            
        }

       

        private void carPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void speedBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
