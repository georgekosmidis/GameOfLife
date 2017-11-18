namespace GameOfLife {
    partial class Grid {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 761);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Of Life";
            this.Load += new System.EventHandler(this.Grid_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion


    }
}

