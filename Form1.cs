using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace lotto
{
    public partial class Form1 : Form
    {
         public class Form2 : Form
         {
            Form2(Form1 parentForm):base()
            {
                this.parentForm = parentForm;
            }
            Form1 parentForm;
  
        }       

        public Form1()
        {
            InitializeComponent();
            
        }

        public Form1(Form2 form2)
        {
            // TODO: Complete member initialization
            this.form2 = form2;
        }
        int zl2 = 2;
        int kasa = 0;
        private Form2 form2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button2zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
                text2zl1.Visible = true;
                text2zl2.Visible = true;
                text2zl3.Visible = true;
                text2zl4.Visible = true;
                text2zl5.Visible = true;
                text2zl6.Visible = true;
                text2zl1.Enabled = true;
                text2zl2.Enabled = true;
                text2zl3.Enabled = true;
                text2zl4.Enabled = true;
                text2zl5.Enabled = true;
                text2zl6.Enabled = true;
                buttonlosowe2zl.Visible = true;
                buttonpotwierdz2zl.Visible = true;
                button2zl.Visible = false;
                labelStopien.Visible = true;
                labelpolawygranej.Visible = true;
                textsuma1.Visible = true;
                textpolawygranej1.Visible = true;
                label1.Visible = true;
                labelwygrana1.Visible = true;
                kasa -= zl2;
                textportfel1.Text = kasa.ToString();
            }

            if (kasa < zl2)
            {
                MessageBox.Show("Cała kasiora przerąbana ;]", "Stan Portfela");
                Application.Restart();
            }
        }

        private void buttonlosowe2zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text2zl1.Text = tab[0].ToString();
            text2zl2.Text = tab[1].ToString();
            text2zl3.Text = tab[2].ToString();
            text2zl4.Text = tab[3].ToString();
            text2zl5.Text = tab[4].ToString();
            text2zl6.Text = tab[5].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonlosowe4zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text4zl1.Text = tab[0].ToString();
            text4zl2.Text = tab[1].ToString();
            text4zl3.Text = tab[2].ToString();
            text4zl4.Text = tab[3].ToString();
            text4zl5.Text = tab[4].ToString();
            text4zl6.Text = tab[5].ToString();
        }

        private void buttonlosowe6zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text6zl1.Text = tab[0].ToString();
            text6zl2.Text = tab[1].ToString();
            text6zl3.Text = tab[2].ToString();
            text6zl4.Text = tab[3].ToString();
            text6zl5.Text = tab[4].ToString();
            text6zl6.Text = tab[5].ToString();
        }

        private void buttonlosowe8zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text8zl1.Text = tab[0].ToString();
            text8zl2.Text = tab[1].ToString();
            text8zl3.Text = tab[2].ToString();
            text8zl4.Text = tab[3].ToString();
            text8zl5.Text = tab[4].ToString();
            text8zl6.Text = tab[5].ToString();
        }

        private void buttonlosowe10zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text10zl1.Text = tab[0].ToString();
            text10zl2.Text = tab[1].ToString();
            text10zl3.Text = tab[2].ToString();
            text10zl4.Text = tab[3].ToString();
            text10zl5.Text = tab[4].ToString();
            text10zl6.Text = tab[5].ToString();
        }

        private void buttonlosowe12zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text12zl1.Text = tab[0].ToString();
            text12zl2.Text = tab[1].ToString();
            text12zl3.Text = tab[2].ToString();
            text12zl4.Text = tab[3].ToString();
            text12zl5.Text = tab[4].ToString();
            text12zl6.Text = tab[5].ToString();
        }

        private void buttonlosowe14zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text14zl1.Text = tab[0].ToString();
            text14zl2.Text = tab[1].ToString();
            text14zl3.Text = tab[2].ToString();
            text14zl4.Text = tab[3].ToString();
            text14zl5.Text = tab[4].ToString();
            text14zl6.Text = tab[5].ToString();
        }

        private void buttonlosowe16zl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            text16zl1.Text = tab[0].ToString();
            text16zl2.Text = tab[1].ToString();
            text16zl3.Text = tab[2].ToString();
            text16zl4.Text = tab[3].ToString();
            text16zl5.Text = tab[4].ToString();
            text16zl6.Text = tab[5].ToString();
        }

        private void button4zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
                text4zl1.Visible = true;
                text4zl2.Visible = true;
                text4zl3.Visible = true;
                text4zl4.Visible = true;
                text4zl5.Visible = true;
                text4zl6.Visible = true;
                text4zl1.Enabled = true;
                text4zl2.Enabled = true;
                text4zl3.Enabled = true;
                text4zl4.Enabled = true;
                text4zl5.Enabled = true;
                text4zl6.Enabled = true;
                buttonlosowe4zl.Visible = true;
                buttonpotwierdz4zl.Visible = true;
                button4zl.Visible = false;
                textsuma2.Visible = true;
                textpolawygranej2.Visible = true;
                label2.Visible = true;
                labelwygrana2.Visible = true;
                kasa -= 2;
                textportfel1.Text = kasa.ToString();
            }
            if (kasa < zl2)
            {
                MessageBox.Show("Nie ma więcej kasy", "Stan Portfela");
                buttonzaakceptujkupon.Visible = true;
                button6zl.Visible = false;
            }
        }

        private void button6zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
                text6zl1.Visible = true;
                text6zl2.Visible = true;
                text6zl3.Visible = true;
                text6zl4.Visible = true;
                text6zl5.Visible = true;
                text6zl6.Visible = true;
                text6zl1.Enabled = true;
                text6zl2.Enabled = true;
                text6zl3.Enabled = true;
                text6zl4.Enabled = true;
                text6zl5.Enabled = true;
                text6zl6.Enabled = true;
                buttonlosowe6zl.Visible = true;
                buttonpotwierdz6zl.Visible = true;
                button6zl.Visible = false;
                textsuma3.Visible = true;
                textpolawygranej3.Visible = true;
                label3.Visible = true;
                labelwygrana3.Visible = true;
                kasa -= 2;
                textportfel1.Text = kasa.ToString();
            }
            if (kasa < zl2)
            {
                MessageBox.Show("Nie ma więcej kasy", "Stan Portfela");
                buttonzaakceptujkupon.Visible = true;
                button8zl.Visible = false;
            }
        }

        private void button8zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
                text8zl1.Visible = true;
                text8zl2.Visible = true;
                text8zl3.Visible = true;
                text8zl4.Visible = true;
                text8zl5.Visible = true;
                text8zl6.Visible = true;
                text8zl1.Enabled = true;
                text8zl2.Enabled = true;
                text8zl3.Enabled = true;
                text8zl4.Enabled = true;
                text8zl5.Enabled = true;
                text8zl6.Enabled = true;
                buttonlosowe8zl.Visible = true;
                buttonpotwierdz8zl.Visible = true;
                button8zl.Visible = false;
                textsuma4.Visible = true;
                textpolawygranej2.Visible = true;
                textsuma4.Visible = true;
                textpolawygranej4.Visible = true;
                label4.Visible = true;
                labelwygrana4.Visible = true;
                kasa -= 2;
                textportfel1.Text = kasa.ToString();
            }
            if (kasa < zl2)
            {
                MessageBox.Show("Nie ma więcej kasy", "Stan Portfela");
                buttonzaakceptujkupon.Visible = true;
                button10zl.Visible = false;
            }
        }

        private void button10zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
                text10zl1.Visible = true;
                text10zl2.Visible = true;
                text10zl3.Visible = true;
                text10zl4.Visible = true;
                text10zl5.Visible = true;
                text10zl6.Visible = true;
                text10zl1.Enabled = true;
                text10zl2.Enabled = true;
                text10zl3.Enabled = true;
                text10zl4.Enabled = true;
                text10zl5.Enabled = true;
                text10zl6.Enabled = true;
                buttonlosowe10zl.Visible = true;
                buttonpotwierdz10zl.Visible = true;
                button10zl.Visible = false;
                textsuma5.Visible = true;
                textpolawygranej5.Visible = true;
                label5.Visible = true;
                labelwygrana5.Visible = true;
                kasa -= 2;
                textportfel1.Text = kasa.ToString();
            }
            if (kasa < zl2)
            {
                MessageBox.Show("Nie ma więcej kasy", "Stan Portfela");
                buttonzaakceptujkupon.Visible = true;
                button12zl.Visible = false;
            }
        }

        private void button12zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
                text12zl1.Visible = true;
                text12zl2.Visible = true;
                text12zl3.Visible = true;
                text12zl4.Visible = true;
                text12zl5.Visible = true;
                text12zl6.Visible = true;
                text12zl1.Enabled = true;
                text12zl2.Enabled = true;
                text12zl3.Enabled = true;
                text12zl4.Enabled = true;
                text12zl5.Enabled = true;
                text12zl6.Enabled = true;
                buttonlosowe12zl.Visible = true;
                buttonpotwierdz12zl.Visible = true;
                button12zl.Visible = false;
                textsuma6.Visible = true;
                textpolawygranej6.Visible = true;
                label6.Visible = true;
                labelwygrana6.Visible = true;
                kasa -= 2;
                textportfel1.Text = kasa.ToString();
            }
            if (kasa < zl2)
            {
                MessageBox.Show("Nie ma więcej kasy", "Stan Portfela");
                buttonzaakceptujkupon.Visible = true;
                button14zl.Visible = false;
            }
        }

        private void button14zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
            text14zl1.Visible = true;
            text14zl2.Visible = true;
            text14zl3.Visible = true;
            text14zl4.Visible = true;
            text14zl5.Visible = true;
            text14zl6.Visible = true;
            text14zl1.Enabled = true;
            text14zl2.Enabled = true;
            text14zl3.Enabled = true;
            text14zl4.Enabled = true;
            text14zl5.Enabled = true;
            text14zl6.Enabled = true;
            buttonlosowe14zl.Visible = true;
            buttonpotwierdz14zl.Visible = true;
            button14zl.Visible = false;
            textsuma7.Visible = true;
            textpolawygranej7.Visible = true;
            label7.Visible = true;
            labelwygrana7.Visible = true;
                kasa -= 2;
                textportfel1.Text = kasa.ToString();
            }
            if (kasa < zl2)
            {
                MessageBox.Show("Nie ma więcej kasy", "Stan Portfela");
                buttonzaakceptujkupon.Visible = true;
                button16zl.Visible = false;
            }
        }

        private void button16zl_Click(object sender, EventArgs e)
        {
            kasa = int.Parse(textportfel1.Text);
            if (kasa >= zl2)
            {
            text16zl1.Visible = true;
            text16zl2.Visible = true;
            text16zl3.Visible = true;
            text16zl4.Visible = true;
            text16zl5.Visible = true;
            text16zl6.Visible = true;
            text16zl1.Enabled = true;
            text16zl2.Enabled = true;
            text16zl3.Enabled = true;
            text16zl4.Enabled = true;
            text16zl5.Enabled = true;
            text16zl6.Enabled = true;
            buttonlosowe16zl.Visible = true;
            buttonpotwierdz16zl.Visible = true;
            button16zl.Visible = false;
            textsuma8.Visible = true;
            textpolawygranej8.Visible = true;
            label8.Visible = true;
            labelwygrana8.Visible = true;
            kasa -= 2;
            textportfel1.Text = kasa.ToString();
            }
            if (kasa < zl2)
            {
                MessageBox.Show("Nie ma więcej kasy", "Stan Portfela");
                buttonzaakceptujkupon.Visible = true;
            }
        }

        private void buttonuruchomieniamaszyny_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] tab = new int[6];
            int i = 0;
            while (i < 6)
            {
                int x = rnd.Next(1, 50);
                if (!tab.Contains(x))
                {
                    tab[i] = x;
                    i++;
                }
            }
            textrandom1.Text = tab[0].ToString();
            textrandom2.Text = tab[1].ToString();
            textrandom3.Text = tab[2].ToString();
            textrandom4.Text = tab[3].ToString();
            textrandom5.Text = tab[4].ToString();
            textrandom6.Text = tab[5].ToString();
            buttonuruchomieniamaszyny.Visible = false;
            buttonoddajkupon.Visible = true;
        }

        private void buttonpotwierdz2zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text2zl1.Text);
            a[1] = int.Parse(text2zl2.Text);
            a[2] = int.Parse(text2zl3.Text);
            a[3] = int.Parse(text2zl4.Text);
            a[4] = int.Parse(text2zl5.Text);
            a[5] = int.Parse(text2zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text2zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text2zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text2zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text2zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text2zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text2zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text2zl1.Enabled = false;
                    text2zl2.Enabled = false;
                    text2zl3.Enabled = false;
                    text2zl4.Enabled = false;
                    text2zl5.Enabled = false;
                    text2zl6.Enabled = false;
                    buttonlosowe2zl.Visible = false;
                    buttonpotwierdz2zl.Visible = false;
                    if (MessageBox.Show("Czy chcesz zamkąć cały kupon?", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        button2zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                    else
                        button4zl.Visible = true;
                }
            }
        }

        private void buttonpotwierdz4zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text4zl1.Text);
            a[1] = int.Parse(text4zl2.Text);
            a[2] = int.Parse(text4zl3.Text);
            a[3] = int.Parse(text4zl4.Text);
            a[4] = int.Parse(text4zl5.Text);
            a[5] = int.Parse(text4zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text4zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text4zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text4zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text4zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text4zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text4zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text4zl1.Enabled = false;
                    text4zl2.Enabled = false;
                    text4zl3.Enabled = false;
                    text4zl4.Enabled = false;
                    text4zl5.Enabled = false;
                    text4zl6.Enabled = false;
                    buttonlosowe4zl.Visible = false;
                    buttonpotwierdz4zl.Visible = false;
                    if (MessageBox.Show("Czy chcesz zamknąc całyn kupon?", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        button4zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                    else
                        button6zl.Visible = true;
                }
            }
        }

        private void buttonpotwierdz6zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text6zl1.Text);
            a[1] = int.Parse(text6zl2.Text);
            a[2] = int.Parse(text6zl3.Text);
            a[3] = int.Parse(text6zl4.Text);
            a[4] = int.Parse(text6zl5.Text);
            a[5] = int.Parse(text6zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text6zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text6zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text6zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text6zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text6zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text6zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text6zl1.Enabled = false;
                    text6zl2.Enabled = false;
                    text6zl3.Enabled = false;
                    text6zl4.Enabled = false;
                    text6zl5.Enabled = false;
                    text6zl6.Enabled = false;
                    buttonlosowe6zl.Visible = false;
                    buttonpotwierdz6zl.Visible = false;
                    if (MessageBox.Show("Czy chcesz zamknąć cały kupon?", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        button6zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                    else
                        button8zl.Visible = true;
                }
            }
        }

        private void buttonpotwierdz8zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text8zl1.Text);
            a[1] = int.Parse(text8zl2.Text);
            a[2] = int.Parse(text8zl3.Text);
            a[3] = int.Parse(text8zl4.Text);
            a[4] = int.Parse(text8zl5.Text);
            a[5] = int.Parse(text8zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text8zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text8zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text8zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text8zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text8zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text8zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text8zl1.Enabled = false;
                    text8zl2.Enabled = false;
                    text8zl3.Enabled = false;
                    text8zl4.Enabled = false;
                    text8zl5.Enabled = false;
                    text8zl6.Enabled = false;
                    buttonlosowe8zl.Visible = false;
                    buttonpotwierdz8zl.Visible = false;
                    if (MessageBox.Show("Czy chcesz zamknąć cały kupon?", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        button8zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                    else
                        button10zl.Visible = true;
                }
            }
        }

        private void buttonpotwierdz10zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text10zl1.Text);
            a[1] = int.Parse(text10zl2.Text);
            a[2] = int.Parse(text10zl3.Text);
            a[3] = int.Parse(text10zl4.Text);
            a[4] = int.Parse(text10zl5.Text);
            a[5] = int.Parse(text10zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text10zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text10zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text10zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text10zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text10zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text10zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text10zl1.Enabled = false;
                    text10zl2.Enabled = false;
                    text10zl3.Enabled = false;
                    text10zl4.Enabled = false;
                    text10zl5.Enabled = false;
                    text10zl6.Enabled = false;
                    buttonlosowe10zl.Visible = false;
                    buttonpotwierdz10zl.Visible = false;
                    if (MessageBox.Show("Czy chcesz zamknąć cały kupon?", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        button10zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                    else
                        button12zl.Visible = true;
                }
            }
        }

        private void buttonpotwierdz12zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text12zl1.Text);
            a[1] = int.Parse(text12zl2.Text);
            a[2] = int.Parse(text12zl3.Text);
            a[3] = int.Parse(text12zl4.Text);
            a[4] = int.Parse(text12zl5.Text);
            a[5] = int.Parse(text12zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text12zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text12zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text12zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text12zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text12zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text12zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text12zl1.Enabled = false;
                    text12zl2.Enabled = false;
                    text12zl3.Enabled = false;
                    text12zl4.Enabled = false;
                    text12zl5.Enabled = false;
                    text12zl6.Enabled = false;
                    buttonlosowe12zl.Visible = false;
                    buttonpotwierdz12zl.Visible = false;
                    if (MessageBox.Show("Czy chcesz zamknąć cały kupon?", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        button12zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                    else
                        button14zl.Visible = true;
                }
            }
        }

        private void buttonpotwierdz14zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text14zl1.Text);
            a[1] = int.Parse(text14zl2.Text);
            a[2] = int.Parse(text14zl3.Text);
            a[3] = int.Parse(text14zl4.Text);
            a[4] = int.Parse(text14zl5.Text);
            a[5] = int.Parse(text14zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text14zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text14zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text14zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text14zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text14zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text14zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text14zl1.Enabled = false;
                    text14zl2.Enabled = false;
                    text14zl3.Enabled = false;
                    text14zl4.Enabled = false;
                    text14zl5.Enabled = false;
                    text14zl6.Enabled = false;
                    buttonlosowe14zl.Visible = false;
                    buttonpotwierdz14zl.Visible = false;
                    if (MessageBox.Show("Czy chcesz zamknąć cały kupon?", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        == DialogResult.Yes)
                    {
                        button14zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                    else
                        button16zl.Visible = true;
                }
            }
        }

        private void buttonpotwierdz16zl_Click(object sender, EventArgs e)
        {
            int[] a = new int[6];
            a[0] = int.Parse(text16zl1.Text);
            a[1] = int.Parse(text16zl2.Text);
            a[2] = int.Parse(text16zl3.Text);
            a[3] = int.Parse(text16zl4.Text);
            a[4] = int.Parse(text16zl5.Text);
            a[5] = int.Parse(text16zl6.Text);
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[0] == 0)
                {
                    text16zl1.BackColor = Color.Yellow;
                }
                if (a[1] == 0)
                {
                    text16zl2.BackColor = Color.Yellow;
                }
                if (a[2] == 0)
                {
                    text16zl3.BackColor = Color.Yellow;
                }
                if (a[3] == 0)
                {
                    text16zl4.BackColor = Color.Yellow;
                }
                if (a[4] == 0)
                {
                    text16zl5.BackColor = Color.Yellow;
                }
                if (a[5] == 0)
                {
                    text16zl6.BackColor = Color.Yellow;
                }
                if (a[i] != 0)
                {
                    s++;
                }
                if (s == 5)
                {
                    text16zl1.Enabled = false;
                    text16zl2.Enabled = false;
                    text16zl3.Enabled = false;
                    text16zl4.Enabled = false;
                    text16zl5.Enabled = false;
                    text16zl6.Enabled = false;
                    buttonlosowe16zl.Visible = false;
                    buttonpotwierdz16zl.Visible = false;
                    if (MessageBox.Show("Wszystkie losy wypełnione!", "Wiadomość dla zamknięcia kuponu",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                        == DialogResult.OK)
                    {
                        button16zl.Visible = false;
                        buttonzaakceptujkupon.Visible = true;
                    }
                }
            }
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (text6zl5.Text == text6zl2.Text)
                text6zl2.Text = "0";
            if (text6zl5.Text == text6zl3.Text)
                text6zl3.Text = "0";
            if (text6zl5.Text == text6zl4.Text)
                text6zl4.Text = "0";
            if (text6zl5.Text == text6zl1.Text)
                text6zl1.Text = "0";
            if (text6zl5.Text == text6zl6.Text)
                text6zl6.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonzaakceptujkupon.Visible = false;
            buttonuruchomieniamaszyny.Visible = true;
            labeluruchomieniemaszyny.Visible = false;
            textsuma1.Text = "0";
            textsuma2.Text = "0";
            textsuma3.Text = "0";
            textsuma4.Text = "0";
            textsuma5.Text = "0";
            textsuma6.Text = "0";
            textsuma7.Text = "0";
            textsuma8.Text = "0";
            textpolawygranej1.Text = "0";
            textpolawygranej2.Text = "0";
            textpolawygranej3.Text = "0";
            textpolawygranej4.Text = "0";
            textpolawygranej5.Text = "0";
            textpolawygranej6.Text = "0";
            textpolawygranej7.Text = "0";
            textpolawygranej8.Text = "0";
        }

        private void buttonoddajkupon_Click(object sender, EventArgs e)
        {

            int[] A = new int[6];
            A[0] = int.Parse(text2zl1.Text);
            A[1] = int.Parse(text2zl2.Text);
            A[2] = int.Parse(text2zl3.Text);
            A[3] = int.Parse(text2zl4.Text);
            A[4] = int.Parse(text2zl5.Text);
            A[5] = int.Parse(text2zl6.Text);         
            int[] B = new int[6];
            B[0] = int.Parse(text4zl1.Text);
            B[1] = int.Parse(text4zl2.Text);
            B[2] = int.Parse(text4zl3.Text);
            B[3] = int.Parse(text4zl4.Text);
            B[4] = int.Parse(text4zl5.Text);
            B[5] = int.Parse(text4zl6.Text);
            int[] C = new int[6];
            C[0] = int.Parse(text6zl1.Text);
            C[1] = int.Parse(text6zl2.Text);
            C[2] = int.Parse(text6zl3.Text);
            C[3] = int.Parse(text6zl4.Text);
            C[4] = int.Parse(text6zl5.Text);
            C[5] = int.Parse(text6zl6.Text);
            int[] D = new int[6];
            D[0] = int.Parse(text8zl1.Text);
            D[1] = int.Parse(text8zl2.Text);
            D[2] = int.Parse(text8zl3.Text);
            D[3] = int.Parse(text8zl4.Text);
            D[4] = int.Parse(text8zl5.Text);
            D[5] = int.Parse(text8zl6.Text);
            int[] E = new int[6];
            E[0] = int.Parse(text10zl1.Text);
            E[1] = int.Parse(text10zl2.Text);
            E[2] = int.Parse(text10zl3.Text);
            E[3] = int.Parse(text10zl4.Text);
            E[4] = int.Parse(text10zl5.Text);
            E[5] = int.Parse(text10zl6.Text);
            int[] F = new int[6];
            F[0] = int.Parse(text12zl1.Text);
            F[1] = int.Parse(text12zl2.Text);
            F[2] = int.Parse(text12zl3.Text);
            F[3] = int.Parse(text12zl4.Text);
            F[4] = int.Parse(text12zl5.Text);
            F[5] = int.Parse(text12zl6.Text);
            int[] G = new int[6];
            G[0] = int.Parse(text14zl1.Text);
            G[1] = int.Parse(text14zl2.Text);
            G[2] = int.Parse(text14zl3.Text);
            G[3] = int.Parse(text14zl4.Text);
            G[4] = int.Parse(text14zl5.Text);
            G[5] = int.Parse(text14zl6.Text);
            int[] H = new int[6];
            H[0] = int.Parse(text16zl1.Text);
            H[1] = int.Parse(text16zl2.Text);
            H[2] = int.Parse(text16zl3.Text);
            H[3] = int.Parse(text16zl4.Text);
            H[4] = int.Parse(text16zl5.Text);
            H[5] = int.Parse(text16zl6.Text);
            int[] A1 = new int[6];
            A1[0]=int.Parse(textrandom1.Text);
            A1[1]=int.Parse(textrandom2.Text);
            A1[2]=int.Parse(textrandom3.Text);
            A1[3]=int.Parse(textrandom4.Text);
            A1[4]=int.Parse(textrandom5.Text);
            A1[5]=int.Parse(textrandom6.Text);
            int a1 = 0, d1 = 0, g1 = 0;
            int b1 = 0, e1 = 0, h1 = 0;
            int c1 = 0, f1 = 0;
            int x = 0, ws3 = 3, ws4 = 4, ws5 = 5, ws6 = 6;
            for (int i = 0; i <= 5; i++ )
            {
                x = i;
                for (int a = 0; a <= 5; a++)
                {
                    if (A[a] == A1[x])
                        a1++;
                    if (A[0] == A1[x])
                        text2zl1.BackColor = Color.Red;
                    if (A[1] == A1[x])
                        text2zl2.BackColor = Color.Red;
                    if (A[2] == A1[x])
                        text2zl3.BackColor = Color.Red;
                    if (A[3] == A1[x])
                        text2zl4.BackColor = Color.Red;
                    if (A[4] == A1[x])
                        text2zl5.BackColor = Color.Red;
                    if (A[5] == A1[x])
                        text2zl6.BackColor = Color.Red;
                }
                textsuma1.Text = a1.ToString();
                if (a1 == ws3)
                {
                    textpolawygranej1.Text = "2";
                }
                if (a1 == ws4)
                {
                    textpolawygranej1.Text = "10";
                }
                if (a1 == ws5)
                {
                    textpolawygranej1.Text = "100";
                }
                if (a1 == ws6)
                {
                    textpolawygranej1.Text = "100000";
                }
                for (int b = 0; b <= 5; b++)
                {
                    if (B[b] == A1[x])
                        b1++;
                    if (B[0] == A1[x])
                        text4zl1.BackColor = Color.Red;
                    if (B[1] == A1[x])
                        text4zl2.BackColor = Color.Red;
                    if (B[2] == A1[x])
                        text4zl3.BackColor = Color.Red;
                    if (B[3] == A1[x])
                        text4zl4.BackColor = Color.Red;
                    if (B[4] == A1[x])
                        text4zl5.BackColor = Color.Red;
                    if (B[5] == A1[x])
                        text4zl6.BackColor = Color.Red;

                }
                textsuma2.Text = b1.ToString();
                if (b1 == ws3)
                {
                    textpolawygranej2.Text = "2";
                }
                if (b1 == ws4)
                {
                    textpolawygranej2.Text = "10";
                }
                if (b1 == ws5)
                {
                    textpolawygranej2.Text = "100";
                }
                if (b1 == ws6)
                {
                    textpolawygranej2.Text = "100000";
                }
                for (int c = 0 ; c <= 5 ; c++)
                {
                    if (C[c] == A1[x])
                        c1++;
                    if (C[0] == A1[x])
                        text6zl1.BackColor = Color.Red;
                    if (C[1] == A1[x])
                        text6zl2.BackColor = Color.Red;
                    if (C[2] == A1[x])
                        text6zl3.BackColor = Color.Red;
                    if (C[3] == A1[x])
                        text6zl4.BackColor = Color.Red;
                    if (C[4] == A1[x])
                        text6zl5.BackColor = Color.Red;
                    if (C[5] == A1[x])
                        text6zl6.BackColor = Color.Red;
                }
                textsuma3.Text = c1.ToString();
                if (c1 == ws3)
                {
                    textpolawygranej3.Text = "2";
                }
                if (c1 == ws4)
                {
                    textpolawygranej3.Text = "10";
                }
                if (c1 == ws5)
                {
                    textpolawygranej3.Text = "100";
                }
                if (c1 == ws6)
                {
                    textpolawygranej3.Text = "100000";
                }
                for (int d = 0; d <= 5; d++)
                {
                    if (D[d] == A1[x])
                        d1++;
                    if (D[0] == A1[x])
                        text8zl1.BackColor = Color.Red;
                    if (D[1] == A1[x])
                        text8zl2.BackColor = Color.Red;
                    if (D[2] == A1[x])
                        text8zl3.BackColor = Color.Red;
                    if (D[3] == A1[x])
                        text8zl4.BackColor = Color.Red;
                    if (D[4] == A1[x])
                        text8zl5.BackColor = Color.Red;
                    if (D[5] == A1[x])
                        text8zl6.BackColor = Color.Red;
                }
                textsuma4.Text = d1.ToString();
                if (d1 == ws3)
                {
                    textpolawygranej4.Text = "2";
                }
                if (d1 == ws4)
                {
                    textpolawygranej4.Text = "10";
                }
                if (d1 == ws5)
                {
                    textpolawygranej4.Text = "100";
                }
                if (d1 == ws6)
                {
                    textpolawygranej4.Text = "100000";
                }
                for (int ee = 0; ee <= 5; ee++)
                {
                    if (E[ee] == A1[x])
                        e1++;
                    if (E[0] == A1[x])
                        text10zl1.BackColor = Color.Red;
                    if (E[1] == A1[x])
                        text10zl2.BackColor = Color.Red;
                    if (E[2] == A1[x])
                        text10zl3.BackColor = Color.Red;
                    if (E[3] == A1[x])
                        text10zl4.BackColor = Color.Red;
                    if (E[4] == A1[x])
                        text10zl5.BackColor = Color.Red;
                    if (E[5] == A1[x])
                        text10zl6.BackColor = Color.Red;

                }
                textsuma5.Text = e1.ToString();
                if (e1 == ws3)
                {
                    textpolawygranej5.Text = "2";
                }
                if (e1 == ws4)
                {
                    textpolawygranej5.Text = "10";
                }
                if (e1 == ws5)
                {
                    textpolawygranej5.Text = "100";
                }
                if (e1 == ws6)
                {
                    textpolawygranej5.Text = "100000";
                }
                for (int f = 0; f <= 5; f++)
                {
                    if (F[f] == A1[x])
                        f1++;
                    if (F[0] == A1[x])
                        text12zl1.BackColor = Color.Red;
                    if (F[1] == A1[x])
                        text12zl2.BackColor = Color.Red;
                    if (F[2] == A1[x])
                        text12zl3.BackColor = Color.Red;
                    if (F[3] == A1[x])
                        text12zl4.BackColor = Color.Red;
                    if (F[4] == A1[x])
                        text12zl5.BackColor = Color.Red;
                    if (F[5] == A1[x])
                        text12zl6.BackColor = Color.Red;
                }
                textsuma6.Text = f1.ToString();
                if (f1 == ws3)
                {
                    textpolawygranej6.Text = "2";
                }
                if (f1 == ws4)
                {
                    textpolawygranej6.Text = "10";
                }
                if (f1 == ws5)
                {
                    textpolawygranej6.Text = "100";
                }
                if (f1 == ws6)
                {
                    textpolawygranej6.Text = "100000";
                }
                for (int g = 0; g <= 5; g++)
                {
                    if (G[g] == A1[x])
                        g1++;
                    if (G[0] == A1[x])
                        text14zl1.BackColor = Color.Red;
                    if (G[1] == A1[x])
                        text14zl2.BackColor = Color.Red;
                    if (G[2] == A1[x])
                        text14zl3.BackColor = Color.Red;
                    if (G[3] == A1[x])
                        text14zl4.BackColor = Color.Red;
                    if (G[4] == A1[x])
                        text14zl5.BackColor = Color.Red;
                    if (G[5] == A1[x])
                        text14zl6.BackColor = Color.Red;

                }
                textsuma7.Text = g1.ToString();
                if (g1 == ws3)
                {
                    textpolawygranej7.Text = "2";
                }
                if (g1 == ws4)
                {
                    textpolawygranej7.Text = "10";
                }
                if (g1 == ws5)
                {
                    textpolawygranej7.Text = "100";
                }
                if (g1 == ws6)
                {
                    textpolawygranej7.Text = "100000";
                }
                for (int h = 0; h <= 5; h++)
                {
                    if (H[h] == A1[x])
                        h1++;
                    if (H[0] == A1[x])
                        text16zl1.BackColor = Color.Red;
                    if (H[1] == A1[x])
                        text16zl2.BackColor = Color.Red;
                    if (H[2] == A1[x])
                        text16zl3.BackColor = Color.Red;
                    if (H[3] == A1[x])
                        text16zl4.BackColor = Color.Red;
                    if (H[4] == A1[x])
                        text16zl5.BackColor = Color.Red;
                    if (H[5] == A1[x])
                        text16zl6.BackColor = Color.Red;
                }
                textsuma8.Text = h1.ToString();
                if (h1 == ws3)
                {
                    textpolawygranej8.Text = "2";
                }
                if (h1 == ws4)
                {
                    textpolawygranej8.Text = "10";
                }
                if (h1 == ws5)
                {
                    textpolawygranej8.Text = "100";
                }
                if (h1 == ws6)
                {
                    textpolawygranej8.Text = "100000";
                }
            }
            buttonoddajkupon.Visible = false;
            buttonreset.Visible = true;
            buttonsprawdzwygrana.Visible = true;
            
        }

        private void text2zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text2zl1.Text == text2zl2.Text)
                text2zl2.Text = "0";
            if (text2zl1.Text == text2zl3.Text)
                text2zl3.Text = "0";
            if (text2zl1.Text == text2zl4.Text)
                text2zl4.Text = "0";
            if (text2zl1.Text == text2zl5.Text)
                text2zl5.Text = "0";
            if (text2zl1.Text == text2zl6.Text)
                text2zl6.Text = "0";
        }

        private void text2zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text2zl2.Text == text2zl1.Text)
                text2zl1.Text = "0";
            if (text2zl2.Text == text2zl3.Text)
                text2zl3.Text = "0";
            if (text2zl2.Text == text2zl4.Text)
                text2zl4.Text = "0";
            if (text2zl2.Text == text2zl5.Text)
                text2zl5.Text = "0";
            if (text2zl2.Text == text2zl6.Text)
                text2zl6.Text = "0";
        }

        private void text2zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text2zl3.Text == text2zl1.Text)
                text2zl1.Text = "0";
            if (text2zl3.Text == text2zl2.Text)
                text2zl2.Text = "0";
            if (text2zl3.Text == text2zl4.Text)
                text2zl4.Text = "0";
            if (text2zl3.Text == text2zl5.Text)
                text2zl5.Text = "0";
            if (text2zl3.Text == text2zl6.Text)
                text2zl6.Text = "0";
        }

        private void text2zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text2zl4.Text == text2zl1.Text)
                text2zl1.Text = "0";
            if (text2zl4.Text == text2zl3.Text)
                text2zl3.Text = "0";
            if (text2zl4.Text == text2zl2.Text)
                text2zl2.Text = "0";
            if (text2zl4.Text == text2zl5.Text)
                text2zl5.Text = "0";
            if (text2zl4.Text == text2zl6.Text)
                text2zl6.Text = "0";
        }

        private void text2zl5_ValueChanged(object sender, EventArgs e)
        {
            if (text2zl5.Text == text2zl2.Text)
                text2zl2.Text = "0";
            if (text2zl5.Text == text2zl3.Text)
                text2zl3.Text = "0";
            if (text2zl5.Text == text2zl4.Text)
                text2zl4.Text = "0";
            if (text2zl5.Text == text2zl1.Text)
                text2zl1.Text = "0";
            if (text2zl5.Text == text2zl6.Text)
                text2zl6.Text = "0";
        }

        private void text2zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text2zl6.Text == text2zl2.Text)
                text2zl2.Text = "0";
            if (text2zl6.Text == text2zl3.Text)
                text2zl3.Text = "0";
            if (text2zl6.Text == text2zl4.Text)
                text2zl4.Text = "0";
            if (text2zl6.Text == text2zl5.Text)
                text2zl5.Text = "0";
            if (text2zl6.Text == text2zl1.Text)
                text2zl1.Text = "0";
        }

        private void text4zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text4zl1.Text == text4zl2.Text)
                text4zl2.Text = "0";
            if (text4zl1.Text == text4zl3.Text)
                text4zl3.Text = "0";
            if (text4zl1.Text == text4zl4.Text)
                text4zl4.Text = "0";
            if (text4zl1.Text == text4zl5.Text)
                text4zl5.Text = "0";
            if (text4zl1.Text == text4zl6.Text)
                text4zl6.Text = "0";
        }

        private void text4zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text4zl2.Text == text4zl1.Text)
                text4zl1.Text = "0";
            if (text4zl2.Text == text4zl3.Text)
                text4zl3.Text = "0";
            if (text4zl2.Text == text4zl4.Text)
                text4zl4.Text = "0";
            if (text4zl2.Text == text4zl5.Text)
                text4zl5.Text = "0";
            if (text4zl2.Text == text4zl6.Text)
                text4zl6.Text = "0";
        }

        private void text4zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text4zl3.Text == text4zl2.Text)
                text4zl2.Text = "0";
            if (text4zl3.Text == text4zl1.Text)
                text4zl1.Text = "0";
            if (text4zl3.Text == text4zl4.Text)
                text4zl4.Text = "0";
            if (text4zl3.Text == text4zl5.Text)
                text4zl5.Text = "0";
            if (text4zl3.Text == text4zl6.Text)
                text4zl6.Text = "0";
        }

        private void text4zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text4zl4.Text == text4zl2.Text)
                text4zl2.Text = "0";
            if (text4zl4.Text == text4zl3.Text)
                text4zl3.Text = "0";
            if (text4zl4.Text == text4zl1.Text)
                text4zl1.Text = "0";
            if (text4zl4.Text == text4zl5.Text)
                text4zl5.Text = "0";
            if (text4zl4.Text == text4zl6.Text)
                text4zl6.Text = "0";
        }

        private void text4zl5_ValueChanged(object sender, EventArgs e)
        {
            if (text4zl5.Text == text4zl2.Text)
                text4zl2.Text = "0";
            if (text4zl5.Text == text4zl3.Text)
                text4zl3.Text = "0";
            if (text4zl5.Text == text4zl4.Text)
                text4zl4.Text = "0";
            if (text4zl5.Text == text4zl1.Text)
                text4zl1.Text = "0";
            if (text4zl5.Text == text4zl6.Text)
                text4zl6.Text = "0";
        }

        private void text4zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text4zl6.Text == text4zl2.Text)
                text4zl2.Text = "0";
            if (text4zl6.Text == text4zl3.Text)
                text4zl3.Text = "0";
            if (text4zl6.Text == text4zl4.Text)
                text4zl4.Text = "0";
            if (text4zl6.Text == text4zl5.Text)
                text4zl5.Text = "0";
            if (text4zl6.Text == text4zl1.Text)
                text4zl1.Text = "0";
        }

        private void text6zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text6zl1.Text == text6zl2.Text)
                text6zl2.Text = "0";
            if (text6zl1.Text == text6zl3.Text)
                text6zl3.Text = "0";
            if (text6zl1.Text == text6zl4.Text)
                text6zl4.Text = "0";
            if (text6zl1.Text == text6zl5.Text)
                text6zl5.Text = "0";
            if (text6zl1.Text == text6zl6.Text)
                text6zl6.Text = "0";
        }

        private void text6zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text6zl2.Text == text6zl1.Text)
                text6zl1.Text = "0";
            if (text6zl2.Text == text6zl3.Text)
                text6zl3.Text = "0";
            if (text6zl2.Text == text6zl4.Text)
                text6zl4.Text = "0";
            if (text6zl2.Text == text6zl5.Text)
                text6zl5.Text = "0";
            if (text6zl2.Text == text6zl6.Text)
                text6zl6.Text = "0";
        }

        private void text6zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text6zl3.Text == text6zl2.Text)
                text6zl2.Text = "0";
            if (text6zl3.Text == text6zl1.Text)
                text6zl1.Text = "0";
            if (text6zl3.Text == text6zl4.Text)
                text6zl4.Text = "0";
            if (text6zl3.Text == text6zl5.Text)
                text6zl5.Text = "0";
            if (text6zl3.Text == text6zl6.Text)
                text6zl6.Text = "0";
        }

        private void text6zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text6zl4.Text == text6zl2.Text)
                text6zl2.Text = "0";
            if (text6zl4.Text == text6zl3.Text)
                text6zl3.Text = "0";
            if (text6zl4.Text == text6zl1.Text)
                text6zl1.Text = "0";
            if (text6zl4.Text == text6zl5.Text)
                text6zl5.Text = "0";
            if (text6zl4.Text == text6zl6.Text)
                text6zl6.Text = "0";
        }

        private void text6zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text6zl6.Text == text6zl2.Text)
                text6zl2.Text = "0";
            if (text6zl6.Text == text6zl3.Text)
                text6zl3.Text = "0";
            if (text6zl6.Text == text6zl4.Text)
                text6zl4.Text = "0";
            if (text6zl6.Text == text6zl5.Text)
                text6zl5.Text = "0";
            if (text6zl6.Text == text6zl1.Text)
                text6zl1.Text = "0";
        }

        private void text8zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text8zl1.Text == text8zl2.Text)
                text8zl2.Text = "0";
            if (text8zl1.Text == text8zl3.Text)
                text8zl3.Text = "0";
            if (text8zl1.Text == text8zl4.Text)
                text8zl4.Text = "0";
            if (text8zl1.Text == text8zl5.Text)
                text8zl5.Text = "0";
            if (text8zl1.Text == text8zl6.Text)
                text8zl6.Text = "0";
        }

        private void text8zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text8zl2.Text == text8zl1.Text)
                text8zl1.Text = "0";
            if (text8zl2.Text == text8zl3.Text)
                text8zl3.Text = "0";
            if (text8zl2.Text == text8zl4.Text)
                text8zl4.Text = "0";
            if (text8zl2.Text == text8zl5.Text)
                text8zl5.Text = "0";
            if (text8zl2.Text == text8zl6.Text)
                text8zl6.Text = "0";
        }

        private void text8zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text8zl3.Text == text8zl2.Text)
                text8zl2.Text = "0";
            if (text8zl3.Text == text8zl1.Text)
                text8zl1.Text = "0";
            if (text8zl3.Text == text8zl4.Text)
                text8zl4.Text = "0";
            if (text8zl3.Text == text8zl5.Text)
                text8zl5.Text = "0";
            if (text8zl3.Text == text8zl6.Text)
                text8zl6.Text = "0";
        }

        private void text8zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text8zl4.Text == text8zl2.Text)
                text8zl2.Text = "0";
            if (text8zl4.Text == text8zl3.Text)
                text8zl3.Text = "0";
            if (text8zl4.Text == text8zl1.Text)
                text8zl1.Text = "0";
            if (text8zl4.Text == text8zl5.Text)
                text8zl5.Text = "0";
            if (text8zl4.Text == text8zl6.Text)
                text8zl6.Text = "0";
        }

        private void text8zl5_ValueChanged(object sender, EventArgs e)
        {
            if (text8zl5.Text == text8zl2.Text)
                text8zl2.Text = "0";
            if (text8zl5.Text == text8zl3.Text)
                text8zl3.Text = "0";
            if (text8zl5.Text == text8zl4.Text)
                text8zl4.Text = "0";
            if (text8zl5.Text == text8zl1.Text)
                text8zl1.Text = "0";
            if (text8zl5.Text == text8zl6.Text)
                text8zl6.Text = "0";
        }

        private void text8zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text8zl6.Text == text8zl2.Text)
                text8zl2.Text = "0";
            if (text8zl6.Text == text8zl3.Text)
                text8zl3.Text = "0";
            if (text8zl6.Text == text8zl4.Text)
                text8zl4.Text = "0";
            if (text8zl6.Text == text8zl5.Text)
                text8zl5.Text = "0";
            if (text8zl6.Text == text8zl1.Text)
                text8zl1.Text = "0";
        }

        private void text10zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text10zl1.Text == text10zl2.Text)
                text10zl2.Text = "0";
            if (text10zl1.Text == text10zl3.Text)
                text10zl3.Text = "0";
            if (text10zl1.Text == text10zl4.Text)
                text10zl4.Text = "0";
            if (text10zl1.Text == text10zl5.Text)
                text10zl5.Text = "0";
            if (text10zl1.Text == text10zl6.Text)
                text10zl6.Text = "0";
        }

        private void text10zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text10zl2.Text == text10zl1.Text)
                text10zl1.Text = "0";
            if (text10zl2.Text == text10zl3.Text)
                text10zl3.Text = "0";
            if (text10zl2.Text == text10zl4.Text)
                text10zl4.Text = "0";
            if (text10zl2.Text == text10zl5.Text)
                text10zl5.Text = "0";
            if (text10zl2.Text == text10zl6.Text)
                text10zl6.Text = "0";
        }

        private void text10zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text10zl3.Text == text10zl2.Text)
                text10zl2.Text = "0";
            if (text10zl3.Text == text10zl1.Text)
                text10zl1.Text = "0";
            if (text10zl3.Text == text10zl4.Text)
                text10zl4.Text = "0";
            if (text10zl3.Text == text10zl5.Text)
                text10zl5.Text = "0";
            if (text10zl3.Text == text10zl6.Text)
                text10zl6.Text = "0";
        }

        private void text10zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text10zl4.Text == text10zl2.Text)
                text10zl2.Text = "0";
            if (text10zl4.Text == text10zl3.Text)
                text10zl3.Text = "0";
            if (text10zl4.Text == text10zl1.Text)
                text10zl1.Text = "0";
            if (text10zl4.Text == text10zl5.Text)
                text10zl5.Text = "0";
            if (text10zl4.Text == text10zl6.Text)
                text10zl6.Text = "0";
        }

        private void text10zl5_ValueChanged(object sender, EventArgs e)
        {
            if (text10zl5.Text == text10zl2.Text)
                text10zl2.Text = "0";
            if (text10zl5.Text == text10zl3.Text)
                text10zl3.Text = "0";
            if (text10zl5.Text == text10zl4.Text)
                text10zl4.Text = "0";
            if (text10zl5.Text == text10zl1.Text)
                text10zl1.Text = "0";
            if (text10zl5.Text == text10zl6.Text)
                text10zl6.Text = "0";
        }

        private void text10zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text10zl6.Text == text10zl2.Text)
                text10zl2.Text = "0";
            if (text10zl6.Text == text10zl3.Text)
                text10zl3.Text = "0";
            if (text10zl6.Text == text10zl4.Text)
                text10zl4.Text = "0";
            if (text10zl6.Text == text10zl5.Text)
                text10zl5.Text = "0";
            if (text10zl6.Text == text10zl1.Text)
                text10zl1.Text = "0";
        }

        private void text12zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text12zl1.Text == text12zl2.Text)
                text12zl2.Text = "0";
            if (text12zl1.Text == text12zl3.Text)
                text12zl3.Text = "0";
            if (text12zl1.Text == text12zl4.Text)
                text12zl4.Text = "0";
            if (text12zl1.Text == text12zl5.Text)
                text12zl5.Text = "0";
            if (text12zl1.Text == text12zl6.Text)
                text12zl6.Text = "0";
        }

        private void text12zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text12zl2.Text == text12zl1.Text)
                text12zl1.Text = "0";
            if (text12zl2.Text == text12zl3.Text)
                text12zl3.Text = "0";
            if (text12zl2.Text == text12zl4.Text)
                text12zl4.Text = "0";
            if (text12zl2.Text == text12zl5.Text)
                text12zl5.Text = "0";
            if (text12zl2.Text == text12zl6.Text)
                text12zl6.Text = "0";
        }

        private void text12zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text12zl3.Text == text12zl2.Text)
                text12zl2.Text = "0";
            if (text12zl3.Text == text12zl1.Text)
                text12zl1.Text = "0";
            if (text12zl3.Text == text12zl4.Text)
                text12zl4.Text = "0";
            if (text12zl3.Text == text12zl5.Text)
                text12zl5.Text = "0";
            if (text12zl3.Text == text12zl6.Text)
                text12zl6.Text = "0";
        }

        private void text12zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text12zl4.Text == text12zl2.Text)
                text12zl2.Text = "0";
            if (text12zl4.Text == text12zl3.Text)
                text12zl3.Text = "0";
            if (text12zl4.Text == text12zl1.Text)
                text12zl1.Text = "0";
            if (text12zl4.Text == text12zl5.Text)
                text12zl5.Text = "0";
            if (text12zl4.Text == text12zl6.Text)
                text12zl6.Text = "0";
        }

        private void text12zl5_ValueChanged(object sender, EventArgs e)
        {
            if (text12zl5.Text == text12zl2.Text)
                text12zl2.Text = "0";
            if (text12zl5.Text == text12zl3.Text)
                text12zl3.Text = "0";
            if (text12zl5.Text == text12zl4.Text)
                text12zl4.Text = "0";
            if (text12zl5.Text == text12zl1.Text)
                text12zl1.Text = "0";
            if (text12zl5.Text == text12zl6.Text)
                text12zl6.Text = "0";
        }

        private void text12zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text12zl6.Text == text12zl2.Text)
                text12zl2.Text = "0";
            if (text12zl6.Text == text12zl3.Text)
                text12zl3.Text = "0";
            if (text12zl6.Text == text12zl4.Text)
                text12zl4.Text = "0";
            if (text12zl6.Text == text12zl5.Text)
                text12zl5.Text = "0";
            if (text12zl6.Text == text12zl1.Text)
                text12zl1.Text = "0";
        }

        private void text14zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text14zl1.Text == text14zl2.Text)
                text14zl2.Text = "0";
            if (text14zl1.Text == text14zl3.Text)
                text14zl3.Text = "0";
            if (text14zl1.Text == text14zl4.Text)
                text14zl4.Text = "0";
            if (text14zl1.Text == text14zl5.Text)
                text14zl5.Text = "0";
            if (text14zl1.Text == text14zl6.Text)
                text14zl6.Text = "0";
        }

        private void text14zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text14zl2.Text == text14zl1.Text)
                text14zl1.Text = "0";
            if (text14zl2.Text == text14zl3.Text)
                text14zl3.Text = "0";
            if (text14zl2.Text == text14zl4.Text)
                text14zl4.Text = "0";
            if (text14zl2.Text == text14zl5.Text)
                text14zl5.Text = "0";
            if (text14zl2.Text == text14zl6.Text)
                text14zl6.Text = "0";
        }

        private void text14zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text14zl3.Text == text14zl2.Text)
                text14zl2.Text = "0";
            if (text14zl3.Text == text14zl1.Text)
                text14zl1.Text = "0";
            if (text14zl3.Text == text14zl4.Text)
                text14zl4.Text = "0";
            if (text14zl3.Text == text14zl5.Text)
                text14zl5.Text = "0";
            if (text14zl3.Text == text14zl6.Text)
                text14zl6.Text = "0";
        }

        private void text14zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text14zl4.Text == text14zl2.Text)
                text14zl2.Text = "0";
            if (text14zl4.Text == text14zl3.Text)
                text14zl3.Text = "0";
            if (text14zl4.Text == text14zl1.Text)
                text14zl1.Text = "0";
            if (text14zl4.Text == text14zl5.Text)
                text14zl5.Text = "0";
            if (text14zl4.Text == text14zl6.Text)
                text14zl6.Text = "0";
        }

        private void text14zl5_ValueChanged(object sender, EventArgs e)
        {
            if (text14zl5.Text == text14zl2.Text)
                text14zl2.Text = "0";
            if (text14zl5.Text == text14zl3.Text)
                text14zl3.Text = "0";
            if (text14zl5.Text == text14zl4.Text)
                text14zl4.Text = "0";
            if (text14zl5.Text == text14zl1.Text)
                text14zl1.Text = "0";
            if (text14zl5.Text == text14zl6.Text)
                text14zl6.Text = "0";
        }

        private void text14zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text14zl6.Text == text14zl2.Text)
                text14zl2.Text = "0";
            if (text14zl6.Text == text14zl3.Text)
                text14zl3.Text = "0";
            if (text14zl6.Text == text14zl4.Text)
                text14zl4.Text = "0";
            if (text14zl6.Text == text14zl5.Text)
                text14zl5.Text = "0";
            if (text14zl6.Text == text14zl1.Text)
                text14zl1.Text = "0";
        }

        private void text16zl1_ValueChanged(object sender, EventArgs e)
        {
            if (text16zl1.Text == text16zl2.Text)
                text16zl2.Text = "0";
            if (text16zl1.Text == text16zl3.Text)
                text16zl3.Text = "0";
            if (text16zl1.Text == text16zl4.Text)
                text16zl4.Text = "0";
            if (text16zl1.Text == text16zl5.Text)
                text16zl5.Text = "0";
            if (text16zl1.Text == text16zl6.Text)
                text16zl6.Text = "0";
        }

        private void text16zl2_ValueChanged(object sender, EventArgs e)
        {
            if (text16zl2.Text == text16zl1.Text)
                text16zl1.Text = "0";
            if (text16zl2.Text == text16zl3.Text)
                text16zl3.Text = "0";
            if (text16zl2.Text == text16zl4.Text)
                text16zl4.Text = "0";
            if (text16zl2.Text == text16zl5.Text)
                text16zl5.Text = "0";
            if (text16zl2.Text == text16zl6.Text)
                text16zl6.Text = "0";
        }

        private void text16zl3_ValueChanged(object sender, EventArgs e)
        {
            if (text16zl3.Text == text16zl2.Text)
                text16zl2.Text = "0";
            if (text16zl3.Text == text16zl1.Text)
                text16zl1.Text = "0";
            if (text16zl3.Text == text16zl4.Text)
                text16zl4.Text = "0";
            if (text16zl3.Text == text16zl5.Text)
                text16zl5.Text = "0";
            if (text16zl3.Text == text16zl6.Text)
                text16zl6.Text = "0";
        }

        private void text16zl4_ValueChanged(object sender, EventArgs e)
        {
            if (text16zl4.Text == text16zl2.Text)
                text16zl2.Text = "0";
            if (text16zl4.Text == text16zl3.Text)
                text16zl3.Text = "0";
            if (text16zl4.Text == text16zl1.Text)
                text16zl1.Text = "0";
            if (text16zl4.Text == text16zl5.Text)
                text16zl5.Text = "0";
            if (text16zl4.Text == text16zl6.Text)
                text16zl6.Text = "0";
        }

        private void text16zl5_ValueChanged(object sender, EventArgs e)
        {
            if (text16zl5.Text == text16zl2.Text)
                text16zl2.Text = "0";
            if (text16zl5.Text == text16zl3.Text)
                text16zl3.Text = "0";
            if (text16zl5.Text == text16zl4.Text)
                text16zl4.Text = "0";
            if (text16zl5.Text == text16zl1.Text)
                text16zl1.Text = "0";
            if (text16zl5.Text == text16zl6.Text)
                text16zl6.Text = "0";
        }

        private void text16zl6_ValueChanged(object sender, EventArgs e)
        {
            if (text16zl6.Text == text16zl2.Text)
                text16zl2.Text = "0";
            if (text16zl6.Text == text16zl3.Text)
                text16zl3.Text = "0";
            if (text16zl6.Text == text16zl4.Text)
                text16zl4.Text = "0";
            if (text16zl6.Text == text16zl5.Text)
                text16zl5.Text = "0";
            if (text16zl6.Text == text16zl1.Text)
                text16zl1.Text = "0";
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            labelsumawygranej.Visible = false;
            textsumawygranych.Visible = false;
            labelpolawygranej.Visible = false;
            labelStopien.Visible = false;
            buttonsprawdzwygrana.Visible = false;
            buttonreset.Visible = false;
            button2zl.Visible = true;
                                                 //reset labeli i textboxów sumatora
            label1.Visible = false;
            labelwygrana1.Visible = false;
            textsuma1.Visible = false;
            textsuma1.Text = "0";
            textpolawygranej1.Visible = false;
            textpolawygranej1.Text = "0";
            label2.Visible = false;
            labelwygrana2.Visible = false;
            textsuma2.Visible = false;
            textsuma2.Text = "0";
            textpolawygranej2.Visible = false;
            textpolawygranej2.Text = "0";
            label3.Visible = false;
            labelwygrana3.Visible = false;
            textsuma3.Visible = false;
            textsuma3.Text = "0";
            textpolawygranej3.Visible = false;
            textpolawygranej3.Text = "0";
            label4.Visible = false;
            labelwygrana4.Visible = false;
            textsuma4.Visible = false;
            textsuma4.Text = "0";
            textpolawygranej4.Visible = false;
            textpolawygranej4.Text = "0";
            label5.Visible = false;
            labelwygrana5.Visible = false;
            textsuma5.Visible = false;
            textsuma5.Text = "0";
            textpolawygranej5.Visible = false;
            textpolawygranej5.Text = "0";
            label6.Visible = false;
            labelwygrana6.Visible = false;
            textsuma6.Visible = false;
            textsuma6.Text = "0";
            textpolawygranej6.Visible = false;
            textpolawygranej6.Text = "0";
            label7.Visible = false;
            labelwygrana7.Visible = false;
            textsuma7.Visible = false;
            textsuma7.Text = "0";
            textpolawygranej7.Visible = false;
            textpolawygranej7.Text = "0";
            label8.Visible = false;
            labelwygrana8.Visible = false;
            textsuma8.Visible = false;
            textsuma8.Text = "0";
            textpolawygranej8.Visible = false;
            textpolawygranej8.Text = "0";

                                                //reset textboxów losu
            text2zl1.Text = "0";
            text2zl1.BackColor = Color.White;
            text2zl2.Text = "0";
            text2zl2.BackColor = Color.White;
            text2zl3.Text = "0";
            text2zl3.BackColor = Color.White;
            text2zl4.Text = "0";
            text2zl4.BackColor = Color.White;
            text2zl5.Text = "0";
            text2zl5.BackColor = Color.White;
            text2zl6.Text = "0";
            text2zl6.BackColor = Color.White;
            text4zl1.Text = "0";
            text4zl1.BackColor = Color.White;
            text4zl2.Text = "0";
            text4zl2.BackColor = Color.White;
            text4zl3.Text = "0";
            text4zl3.BackColor = Color.White;
            text4zl4.Text = "0";
            text4zl4.BackColor = Color.White;
            text4zl5.Text = "0";
            text4zl5.BackColor = Color.White;
            text4zl6.Text = "0";
            text4zl6.BackColor = Color.White;
            text6zl1.Text = "0";
            text6zl1.BackColor = Color.White;
            text6zl2.Text = "0";
            text6zl2.BackColor = Color.White;
            text6zl3.Text = "0";
            text6zl3.BackColor = Color.White;
            text6zl4.Text = "0";
            text6zl4.BackColor = Color.White;
            text6zl5.Text = "0";
            text6zl5.BackColor = Color.White;
            text6zl6.Text = "0";
            text6zl6.BackColor = Color.White;
            text8zl1.Text = "0";
            text8zl1.BackColor = Color.White;
            text8zl2.Text = "0";
            text8zl2.BackColor = Color.White;
            text8zl3.Text = "0";
            text8zl3.BackColor = Color.White;
            text8zl4.Text = "0";
            text8zl4.BackColor = Color.White;
            text8zl5.Text = "0";
            text8zl5.BackColor = Color.White;
            text8zl6.Text = "0";
            text8zl6.BackColor = Color.White;
            text10zl1.Text = "0";
            text10zl1.BackColor = Color.White;
            text10zl2.Text = "0";
            text10zl2.BackColor = Color.White;
            text10zl3.Text = "0";
            text10zl3.BackColor = Color.White;
            text10zl4.Text = "0";
            text10zl4.BackColor = Color.White;
            text10zl5.Text = "0";
            text10zl5.BackColor = Color.White;
            text10zl6.Text = "0";
            text10zl6.BackColor = Color.White;
            text12zl1.Text = "0";
            text12zl1.BackColor = Color.White;
            text12zl2.Text = "0";
            text12zl2.BackColor = Color.White;
            text12zl3.Text = "0";
            text12zl3.BackColor = Color.White;
            text12zl4.Text = "0";
            text12zl4.BackColor = Color.White;
            text12zl5.Text = "0";
            text12zl5.BackColor = Color.White;
            text12zl6.Text = "0";
            text12zl6.BackColor = Color.White;
            text14zl1.Text = "0"; 
            text14zl1.BackColor = Color.White;
            text14zl2.Text = "0";
            text14zl2.BackColor = Color.White;
            text14zl3.Text = "0";
            text14zl3.BackColor = Color.White;
            text14zl4.Text = "0";
            text14zl4.BackColor = Color.White;
            text14zl5.Text = "0";
            text14zl5.BackColor = Color.White;
            text14zl6.Text = "0";
            text14zl6.BackColor = Color.White;
            text16zl1.Text = "0";
            text16zl1.BackColor = Color.White;
            text16zl2.Text = "0";
            text16zl2.BackColor = Color.White;
            text16zl3.Text = "0";
            text16zl3.BackColor = Color.White;
            text16zl4.Text = "0";
            text16zl4.BackColor = Color.White;
            text16zl5.Text = "0";
            text16zl5.BackColor = Color.White;
            text16zl6.Text = "0";
            text16zl6.BackColor = Color.White;
                                                    // reset textboxów maszyny
            textrandom1.Text = "0";
            textrandom2.Text = "0";
            textrandom3.Text = "0";
            textrandom4.Text = "0";
            textrandom5.Text = "0";
            textrandom6.Text = "0";
                                                    //reset ustawień widoczności dla textboxów losu
            text2zl1.Visible = false;
            text2zl2.Visible = false;
            text2zl3.Visible = false;
            text2zl4.Visible = false;
            text2zl5.Visible = false;
            text2zl6.Visible = false;
            text2zl1.Enabled = false;
            text2zl2.Enabled = false;
            text2zl3.Enabled = false;
            text2zl4.Enabled = false;
            text2zl5.Enabled = false;
            text2zl6.Enabled = false;
            text4zl1.Visible = false;
            text4zl2.Visible = false;
            text4zl3.Visible = false;
            text4zl4.Visible = false;
            text4zl5.Visible = false;
            text4zl6.Visible = false;
            text6zl1.Visible = false;
            text6zl2.Visible = false;
            text6zl3.Visible = false;
            text6zl4.Visible = false;
            text6zl5.Visible = false;
            text6zl6.Visible = false;
            text8zl1.Visible = false;
            text8zl2.Visible = false;
            text8zl3.Visible = false;
            text8zl4.Visible = false;
            text8zl5.Visible = false;
            text8zl6.Visible = false;
            text10zl1.Visible = false;
            text10zl2.Visible = false;
            text10zl3.Visible = false;
            text10zl4.Visible = false;
            text10zl5.Visible = false;
            text10zl6.Visible = false;
            text12zl1.Visible = false;
            text12zl2.Visible = false;
            text12zl3.Visible = false;
            text12zl4.Visible = false;
            text12zl5.Visible = false;
            text12zl6.Visible = false;
            text14zl1.Visible = false;
            text14zl2.Visible = false;
            text14zl3.Visible = false;
            text14zl4.Visible = false;
            text14zl5.Visible = false;
            text14zl6.Visible = false;
            text16zl1.Visible = false;
            text16zl2.Visible = false;
            text16zl3.Visible = false;
            text16zl4.Visible = false;
            text16zl5.Visible = false;
            text16zl6.Visible = false;

        }

        private void buttonsprawdzwygrana_Click(object sender, EventArgs e)
        {
            buttonsprawdzwygrana.Visible = false;
            textsumawygranych.Visible = true;
            labelsumawygranej.Visible = true;
            int a2 = int.Parse(textpolawygranej1.Text);
            int b2 = int.Parse(textpolawygranej2.Text);
            int c2 = int.Parse(textpolawygranej3.Text);
            int d2 = int.Parse(textpolawygranej4.Text);
            int e2 = int.Parse(textpolawygranej5.Text);
            int f2 = int.Parse(textpolawygranej6.Text);
            int g2 = int.Parse(textpolawygranej7.Text);
            int h2 = int.Parse(textpolawygranej8.Text);
            int suma = 0;
            suma = a2 + b2 + c2 + d2 + e2 + f2 + g2 + h2;
            textsumawygranych.Text = suma.ToString();
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            int a3 = int.Parse(textsumawygranych.Text);
            int b3 = int.Parse(textportfel1.Text);
            int suma3 = 0;
            suma3 = a3 + b3;
            textportfel1.Text = suma3.ToString();
        }
    }
}
