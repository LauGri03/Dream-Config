using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Config
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = InstalledLanguages.GetLanguages();
            comboBox1.DataSource = InstalledPrograms.GetInstalledPrograms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                CreateFile.Create(comboBox1.Text, trackBar1.Value, trackBar2.Value, comboBox2.Text);
            else
                CreateFile.Create(comboBox1.Text, trackBar1.Value, comboBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateFile.Create("Defaut", 80, "fr-CA");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                trackBar2.Enabled = true;
            else
                trackBar2.Enabled = false;
            
        }
    }
    }
