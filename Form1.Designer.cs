namespace BombaYagisi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bomba1 = new System.Windows.Forms.PictureBox();
            this.bomba2 = new System.Windows.Forms.PictureBox();
            this.adamSol = new System.Windows.Forms.PictureBox();
            this.adamSag = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bomba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamSag)).BeginInit();
            this.SuspendLayout();
            // 
            // bomba1
            // 
            this.bomba1.BackColor = System.Drawing.Color.Transparent;
            this.bomba1.Location = new System.Drawing.Point(80, 30);
            this.bomba1.Name = "bomba1";
            this.bomba1.Size = new System.Drawing.Size(55, 55);
            this.bomba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomba1.TabIndex = 0;
            this.bomba1.TabStop = false;
            // 
            // bomba2
            // 
            this.bomba2.BackColor = System.Drawing.Color.Transparent;
            this.bomba2.Location = new System.Drawing.Point(290, 30);
            this.bomba2.Name = "bomba2";
            this.bomba2.Size = new System.Drawing.Size(55, 55);
            this.bomba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomba2.TabIndex = 1;
            this.bomba2.TabStop = false;
            // 
            // adamSol
            // 
            this.adamSol.BackColor = System.Drawing.Color.Transparent;
            this.adamSol.Location = new System.Drawing.Point(160, 600);
            this.adamSol.Name = "adamSol";
            this.adamSol.Size = new System.Drawing.Size(55, 55);
            this.adamSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adamSol.TabIndex = 2;
            this.adamSol.TabStop = false;
            // 
            // adamSag
            // 
            this.adamSag.BackColor = System.Drawing.Color.Transparent;
            this.adamSag.Location = new System.Drawing.Point(225, 600);
            this.adamSag.Name = "adamSag";
            this.adamSag.Size = new System.Drawing.Size(55, 55);
            this.adamSag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adamSag.TabIndex = 3;
            this.adamSag.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 681);
            this.Controls.Add(this.adamSag);
            this.Controls.Add(this.adamSol);
            this.Controls.Add(this.bomba2);
            this.Controls.Add(this.bomba1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(450, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bomba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adamSag)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox bomba1;
        private System.Windows.Forms.PictureBox bomba2;
        private System.Windows.Forms.PictureBox adamSol;
        private System.Windows.Forms.PictureBox adamSag;
        private System.Windows.Forms.Timer timer1;
    }
}
