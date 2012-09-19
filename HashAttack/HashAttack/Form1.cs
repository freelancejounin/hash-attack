using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HashAttack
{
    public partial class Form1 : Form
    {
        private Attacker attacker;

        public Form1()
        {
            InitializeComponent();
            bStart.Click += new EventHandler(bStart_Click);

            attacker = new Attacker();
        }

        void bStart_Click(object sender, EventArgs e)
        {
            String[] results;

            if (tbInput.Text.Length == 0)
                results = attacker.TestCollisionAttack();
            else
                results = attacker.TestPreimageAttack(tbInput.Text);
            
            if ((results == null) || (results.Length < 5))
                return;

            lblString1.Text = "String1\n" + results[0];
            lblString2.Text = "String2\n" + results[1];
            lblHashOut.Text = "Colliding Hash\n" + results[2] + "\n" + results[3];
            lblTime.Text = "Time Taken\n" + results[4];
        }
    }
}
