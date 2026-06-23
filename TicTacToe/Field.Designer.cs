namespace TicTacToe
{
    partial class Field
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 5);
            label1.MaximumSize = new Size(190, 190);
            label1.MinimumSize = new Size(190, 190);
            label1.Name = "label1";
            label1.Size = new Size(190, 190);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Field
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(label1);
            Name = "Field";
            Size = new Size(200, 200);
            Load += Field_Load;
            Click += label1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
