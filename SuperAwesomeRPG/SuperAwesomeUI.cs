using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperAwesomeGameEngine;

namespace SuperAwesomeRPG
{
    public partial class SuperAwesomeUI : Form
    {
        private Player _player;
        public SuperAwesomeUI()
        {
            InitializeComponent();

            //Location location = new Location();
            //location.ID = 1;
            //location.Name = "Home";
            //location.Description = "This is your house.";
            //Instantiation of the Location object has changed after adding parameters to the class constructor.

            Location location = new Location(1, "Home", "This is your house.");

            //_player = new Player();
            //_player.CurrentHitPoints = 10;
            //_player.MaximumHitPoints = 10;
            //_player.Gold = 20;
            //_player.ExperiencePoints = 0;
            //_player.Level = 1;
            //Instantiation of the Player object has changed after adding parameters to the class constructor.

            _player = new Player(20, 0, 1, 10, 10);
            //The variable '_player' of the datatype 'Player' has already been declared so it only needs to be assigned a value.

            lblHitPoints.Text = _player.CurrentHitPoints.ToString() + " (of " + _player.MaximumHitPoints.ToString() + ")";
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString() + " (??? XP to level " + (_player.Level + 1) + ")";
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
