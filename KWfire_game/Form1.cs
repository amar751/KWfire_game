using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWfire_game
{
    public partial class Form1 : Form
    {
        int shot = 0;
        int shotAway = 0;
        int trigger = 0;
        fire obj_fire = new fire();

        public Form1()
        {

            InitializeComponent();
            //disable the button of the game 
            btnSpin.Enabled = false;
            btnShot.Enabled = false;
            btnShootAway.Enabled = false;
            trigger = obj_fire.genNo(1,3);
        }

     

        private void btnSpin_Click(object sender, EventArgs e)
        {
            //disable itself after clicking on the game 
            btnSpin.Enabled = false;
            btnShot.Enabled = true;
            btnShootAway.Enabled = true;
            //load the image of the gun to shoot 
            pictureBox1.Image = KWfire_game.Properties.Resources.spin;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // hide the label and visible the picture box to thus we can play the game 
            label1.Visible = false;
            pictureBox1.Visible = true;
            btnSpin.Enabled = true;
            btnLoad.Enabled = false;
            //load the image of the gun to shoot 
            pictureBox1.Image= KWfire_game.Properties.Resources.load;

        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            //load the image of the shoot gun 
            shot++;

            pictureBox1.Image = KWfire_game.Properties.Resources.shoot;
            // generate the sound of the fire 
            if (shot == trigger && shot <= 6)
            {
                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(KWfire_game.Properties.Resources.fire);
                obj.Play();
                trigger = obj_fire.genNo(4,6);
            }

            if (shot == trigger)
            {
                MessageBox.Show("You won the game  ");
                btnShot.Enabled = false;
            }
            
            //after six fire over the game 
            if (shot==6){
                btnShot.Enabled = false;
                MessageBox.Show("Your chance are over ");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the game 
            this.Close();
        }

        private void btnShootAway_Click(object sender, EventArgs e)
        {
            //count the shootaway chances 
            shotAway++;

            //generate the sound of fire 
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(KWfire_game.Properties.Resources.fire);
            obj.Play();

            
            // after using all chance over the game 
            if (shotAway==2) {
                btnShootAway.Enabled = false;
                MessageBox.Show("chance's are over ");
                btnLoad.Enabled = false;

            }
        }
    }
}

