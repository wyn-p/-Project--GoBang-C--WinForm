﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoBang
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {

            Form_Game game=new Form_Game();
            game.ShowDialog(this);
        }
    }
}
