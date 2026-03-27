using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projComputadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        {
            float valor;

            listBox1.Items.Clear();

            // note ou pc
            if (comboBox1.SelectedIndex == 0)
            {
                valor = 1600;
                listBox1.Items.Add("Computador: " + comboBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                valor = 1000;
                listBox1.Items.Add("Computador: " + comboBox1.Text);
            }
            else
            {
                valor = 0;
                listBox1.Items.Add("Computador: " + comboBox1.Text);
            }

            // processador
            if (radioButton1.Checked == true)
            {
                valor += 0;
                listBox1.Items.Add("Processador: " + radioButton1.Text);
            }

            if (radioButton2.Checked == true)
            {
                valor += 250;
                listBox1.Items.Add("Processador: " + radioButton2.Text);
            }

            // memória
            if (radioButton3.Checked == true)
            {
                valor += 0;
                listBox1.Items.Add("Memória: " + radioButton3.Text);
            }

            if (radioButton4.Checked == true)
            {
                valor += 100;
                listBox1.Items.Add("Memória: " + radioButton4.Text);
            }

            if (radioButton5.Checked == true)
            {
                valor += 150;
                listBox1.Items.Add("Memória: " + radioButton5.Text);
            }

            // hd
            if (radioButton6.Checked == true)
            {
                valor += 0;
                listBox1.Items.Add("HD: " + radioButton6.Text);
            }

            if (radioButton7.Checked == true)
            {
                valor += 200;
                listBox1.Items.Add("HD: " + radioButton7.Text);
            }

            // acessórios
            if (checkBox1.Checked == true)
            {
                valor += 200;
                listBox1.Items.Add("Sistema Operacional: " + checkBox1.Text);
            }

            if (checkBox2.Checked == true)
            {
                valor += 70;
                listBox1.Items.Add("Antivírus: " + checkBox2.Text);
            }

            if (checkBox3.Checked == true)
            {
                valor += 200;
                listBox1.Items.Add("Microsoft Office: " + checkBox3.Text);
            }

            // exibindo resultado
            textBox1.Text = Convert.ToDouble(valor).ToString("R$ ###,###,##0.00");

            listBox1.Items.Add("----------------------");
            listBox1.Items.Add("Total: " + textBox1.Text);
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            { 
            comboBox1.SelectedIndex = -1;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            textBox1.Clear();
            listBox1.Items.Clear();

            pictureBox1.Image = null;
        }
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("computador.png");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("notebook.png");
            }
        }
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
