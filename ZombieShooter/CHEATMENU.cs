using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZombieShooter.Maps;

namespace ZombieShooter
{
    public partial class CHEATMENU : Form
    {
        TestingMapForm testingmapform;
        public CHEATMENU(TestingMapForm existingMapForm, Player1 player1)
        {
            InitializeComponent();
            testingmapform = existingMapForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testingmapform != null)
            {
                testingmapform.player1Score += 10000;
            }
        }
    }
}
