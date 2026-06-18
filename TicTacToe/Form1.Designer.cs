namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            field1 = new Field();
            field2 = new Field();
            field3 = new Field();
            field4 = new Field();
            field5 = new Field();
            field6 = new Field();
            field7 = new Field();
            field8 = new Field();
            field9 = new Field();
            SuspendLayout();
            // 
            // field1
            // 
            field1.BackColor = SystemColors.ButtonShadow;
            field1.Location = new Point(28, 34);
            field1.Name = "field1";
            field1.Size = new Size(200, 200);
            field1.TabIndex = 0;

            // 
            // field2
            // 
            field2.BackColor = SystemColors.ButtonShadow;
            field2.Location = new Point(234, 34);
            field2.Name = "field2";
            field2.Size = new Size(200, 200);
            field2.TabIndex = 1;

            // 
            // field3
            // 
            field3.BackColor = SystemColors.ButtonShadow;
            field3.Location = new Point(440, 34);
            field3.Name = "field3";
            field3.Size = new Size(200, 200);
            field3.TabIndex = 2;

            // 
            // field4
            // 
            field4.BackColor = SystemColors.ButtonShadow;
            field4.Location = new Point(440, 240);
            field4.Name = "field4";
            field4.Size = new Size(200, 200);
            field4.TabIndex = 5;
            // 
            // field5
            // 
            field5.BackColor = SystemColors.ButtonShadow;
            field5.Location = new Point(234, 240);
            field5.Name = "field5";
            field5.Size = new Size(200, 200);
            field5.TabIndex = 4;
            // 
            // field6
            // 
            field6.BackColor = SystemColors.ButtonShadow;
            field6.Location = new Point(28, 240);
            field6.Name = "field6";
            field6.Size = new Size(200, 200);
            field6.TabIndex = 3;
            // 
            // field7
            // 
            field7.BackColor = SystemColors.ButtonShadow;
            field7.Location = new Point(440, 446);
            field7.Name = "field7";
            field7.Size = new Size(200, 200);
            field7.TabIndex = 8;
            // 
            // field8
            // 
            field8.BackColor = SystemColors.ButtonShadow;
            field8.Location = new Point(234, 446);
            field8.Name = "field8";
            field8.Size = new Size(200, 200);
            field8.TabIndex = 7;
            // 
            // field9
            // 
            field9.BackColor = SystemColors.ButtonShadow;
            field9.Location = new Point(28, 446);
            field9.Name = "field9";
            field9.Size = new Size(200, 200);
            field9.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 709);
            Controls.Add(field7);
            Controls.Add(field8);
            Controls.Add(field9);
            Controls.Add(field4);
            Controls.Add(field5);
            Controls.Add(field6);
            Controls.Add(field3);
            Controls.Add(field2);
            Controls.Add(field1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Field field1;
        private Field field2;
        private Field field3;
        private Field field4;
        private Field field5;
        private Field field6;
        private Field field7;
        private Field field8;
        private Field field9;
    }
}
