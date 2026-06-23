using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Field : UserControl
    {
        private static bool isX = true;

        public event EventHandler FeldWurdeGeklickt;

        public string Symbol
        {
            get { return label1.Text; }
        }

        public Field()
        {
            InitializeComponent();
        }

        private void Field_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                if (isX)
                    label1.Text = "X";
                else
                    label1.Text = "O";

                isX = !isX;

                FeldWurdeGeklickt?.Invoke(this, EventArgs.Empty);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Field_Click(sender, e);
        }

        private void Field_Load(object sender, EventArgs e)
        {

        }


    }
}
