﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euromilhoes_Finau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        euromilhoes E = new euromilhoes();
        

        private void estrela(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Text = E.estrela(Convert.ToInt32(temp.Tag)-1);
            teste.Text = E.listanest;

        }


        private void numeros(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Text = E.numero(Convert.ToInt32(temp.Tag)-1);
            teste.Text = E.listanum;
        }

    }

}

