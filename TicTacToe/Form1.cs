namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            field1.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field2.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field3.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field4.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field5.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field6.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field7.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field8.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
            field9.FeldWurdeGeklickt += Field_FeldWurdeGeklickt;
        }

        private void Field_FeldWurdeGeklickt(object sender, EventArgs e)
        {
            PruefeGewinner();
        }
        private void PruefeGewinner()
        {
            if (
                Gleich(field1, field2, field3) ||
                Gleich(field6, field5, field4) ||
                Gleich(field9, field8, field7) ||

                Gleich(field1, field6, field9) ||
                Gleich(field2, field5, field8) ||
                Gleich(field3, field4, field7) ||

                Gleich(field1, field5, field7) ||
                Gleich(field3, field5, field9)
               )
            {
                MessageBox.Show("Du hast gewonnen!");
            }
        }

        private bool Gleich(Field a, Field b, Field c)
        {
            return a.Symbol != "" &&
                   a.Symbol == b.Symbol &&
                   b.Symbol == c.Symbol;
        }
    }
}
