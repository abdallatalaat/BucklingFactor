using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BucklingFactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ga_isdirect_CheckedChanged(object sender, EventArgs e)
        {
            bool is_d = ga_isdirect.Checked;
            ga_direct.Enabled = is_d;
            ga_label.Enabled = is_d;
            a_stiffness.Enabled = !is_d;
            m_stiffness.Enabled = !(is_d && gb_isdirect.Checked);

            Calculate_k();

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool is_d = radioButton1.Checked;
            ga_direct.Enabled = !is_d;
            ga_label.Enabled = !is_d;
            a_stiffness.Enabled = is_d;
            m_stiffness.Enabled = is_d;

            Calculate_k();
        }
        private void gb_isdirect_CheckedChanged(object sender, EventArgs e)
        {
            bool is_d = gb_isdirect.Checked;
            gb_direct.Enabled = is_d;
            gb_label.Enabled = is_d;
            b_stiffness.Enabled = !is_d;
            m_stiffness.Enabled = !(is_d && ga_isdirect.Checked);

            Calculate_k();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool is_d = radioButton2.Checked;
            gb_direct.Enabled = !is_d;
            gb_label.Enabled = !is_d;
            b_stiffness.Enabled = is_d;
            m_stiffness.Enabled = is_d;

            Calculate_k();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void k_label_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(k_label.Text);
        }

        private void update_k(object sender, EventArgs e)
        {
            Calculate_k();
        }
    }

    
}
