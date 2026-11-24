using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BombaYagisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int addim, suret1, suret2;

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            string imgFolder = Path.Combine(Application.StartupPath, "images");
            if (File.Exists(Path.Combine(imgFolder, "bomba.png")))
            {
                bomba1.Image = Image.FromFile(Path.Combine(imgFolder, "bomba.png"));
                bomba2.Image = Image.FromFile(Path.Combine(imgFolder, "bomba.png"));
            }
            if (File.Exists(Path.Combine(imgFolder, "adam_sol.png")))
            {
                adamSol.Image = Image.FromFile(Path.Combine(imgFolder, "adam_sol.png"));
            }
            if (File.Exists(Path.Combine(imgFolder, "adam_sag.png")))
            {
                adamSag.Image = Image.FromFile(Path.Combine(imgFolder, "adam_sag.png"));
            }

            Yeni();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                adamSol.Visible = true;
                adamSag.Visible = false;

                if (adamSol.Left - 20 >= 0)
                {
                    adamSol.Left -= 20;
                    adamSag.Left = adamSol.Left;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                adamSag.Visible = true;
                adamSol.Visible = false;

                if (adamSag.Left + adamSag.Width + 20 <= ClientSize.Width)
                {
                    adamSag.Left += 20;
                    adamSol.Left = adamSag.Left;
                }
            }
            else
            {
                adamSol.Visible = false;
                adamSag.Visible = false;
            }
        }

        void Yeni()
        {
            addim = 0;

            adamSol.Left = 200;
            adamSol.Top = 600;
            adamSag.Left = 200;
            adamSag.Top = 600;

            adamSol.Visible = false;
            adamSag.Visible = false;

            Yerlesdir(bomba1);
            Yerlesdir(bomba2);

            suret1 = r.Next(8, 15);
            suret2 = r.Next(8, 15);

            timer1.Start();
        }

        void Yerlesdir(PictureBox p)
        {
            p.Left = r.Next(0, ClientSize.Width - p.Width);
            p.Top = r.Next(-150, -30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bomba1.Top += suret1;
            bomba2.Top += suret2;

            if (bomba1.Top > ClientSize.Height)
            {
                addim++;
                Yerlesdir(bomba1);
                suret1 = r.Next(8, 15);
            }

            if (bomba2.Top > ClientSize.Height)
            {
                addim++;
                Yerlesdir(bomba2);
                suret2 = r.Next(8, 15);
            }

            if ((adamSol.Visible && (adamSol.Bounds.IntersectsWith(bomba1.Bounds) || adamSol.Bounds.IntersectsWith(bomba2.Bounds))) ||
                (adamSag.Visible && (adamSag.Bounds.IntersectsWith(bomba1.Bounds) || adamSag.Bounds.IntersectsWith(bomba2.Bounds))))
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitdi! Sizin nəticə: " + addim, "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult cavab = MessageBox.Show("Yeni oyun başlasınmı?", "Məlumat", MessageBoxButtons.YesNo);
                if (cavab == DialogResult.Yes)
                {
                    Yeni();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
