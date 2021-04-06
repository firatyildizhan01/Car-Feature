using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            araba cfd = new araba();
            cfd.carRenk = "yellow";
            cfd.arabaLimit = 14.454;
            cfd.arabaYas = 27;
            cfd.arabaGüc = 387;
            cfd.durum = "iyi";
            cfd.YIL = -1984.8;
            cfd.Isım = "mehmetX";
            cfd.arabacı = "teyzeYaşlı";
            cfd.arabaLazerGücü = 213;
            cfd.kendisi = "ayşe teyze";

            label1.Text = cfd.carRenk;
            label2.Text = cfd.arabaLimit.ToString();
            label3.Text = cfd.arabaYas.ToString();
            label4.Text = cfd.arabaGüc.ToString();
            label5.Text = cfd.durum;
            label6.Text = cfd.YIL.ToString();
            label7.Text = cfd.Isım;
            label8.Text = cfd.arabacı;
            label9.Text = cfd.arabaLazerGücü.ToString();
            label10.Text = cfd.kendisi;


            pictureBox1.BackColor = Color.YellowGreen;



        }
    }
}
