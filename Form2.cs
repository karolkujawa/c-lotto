using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lotto
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            Visible = false;
            form2.Show();
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        void handleUpdateEvent(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            /*"Po wyborze gry program pyta użytkownika o podanie 6 liczb z zakresu
            (1 do 49). Podawane dane maja być weryfikowane pod względem
            wartości, typu jak również nie mogą się powtarzać! Następnie program w
            sposób losowy wygeneruje 6 liczb i wyświetli wynik. Poniżej wyniku
            wyświetlone zostaną typowania gracza. Jeśli były trafne typowania
            program je zaznaczy (nawiasem lub kolorem)"*/
        }
    }
}
