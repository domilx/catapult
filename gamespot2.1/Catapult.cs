using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamespot2._1
{
    public partial class Catapult : Form
    {
        public Catapult()
        {
            InitializeComponent();
            DialogResult dialogResult = MessageBox.Show("Do you want to donate to me and encourage the making of future folow-ups? Then buy me a coffee!", "Buy me a coffee!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://ko-fi.com/D1D77RUZC");
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\fnaf\\fnaf1.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\fnaf\\fnaf2.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\fnaf\\fnaf3.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\fnaf\\fnaf4.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\ct\\Clustertruck.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\ravenfeild\\ravenfield.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\plague\\PlagueIncEvolved.exe");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\pcbuilder\\PC Creator.exe");
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\gd\\GeometryDash.exe");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Process.Start("Assets\\doom\\DOOM64_x64.exe");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("Assets\\ImpossiPong.exe");
        }
    }
}