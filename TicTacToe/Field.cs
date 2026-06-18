using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Field : UserControl
    {
        public Field()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Field_Load(object sender, EventArgs e)
        {

        }

        private void Field_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wurde angeklickt!");
        }
    }
}
