using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birincikopeksolauzaklık, ikincikopeksolauzaklık, ucuncukopeksolauzaklık, dördüncükopeksolauzaklıklık;
     public  int gurkanbakiye = 50, alibakiye = 75, göktürkbakiye = 35;
       
        private String secim1;
        private String secim2;
        private String secim3;
        private int bahis1;
        private int bahis2;
        private int bahis3;

        public int Bahis1
        {
            get { return bahis1; }
            set { bahis1 = value; }
        }
        public int Bahis2
        {
            get { return bahis2; }
            set { bahis2 = value; }
        }
        public int Bahis3
        {
            get { return bahis3; }
            set { bahis3 = value; }
        }

        //******************************************************************
        public String Secim1 {
            get { return secim1; }
            set { secim1 = value; }
        }
        public String Secim2
        {
            get { return secim2; }
            set { secim2 = value; }
        }
        public String Secim3
        {
            get { return secim3; }
            set { secim3 = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            birincikopeksolauzaklık = pictureBox1.Left;
            ikincikopeksolauzaklık = pictureBox2.Left;
            ucuncukopeksolauzaklık = pictureBox3.Left;
            dördüncükopeksolauzaklıklık = pictureBox4.Left;
        }
        Random random = new Random();

        public void timer1_Tick(object sender, EventArgs e)
        {
            int birinicikopegingenisligi = pictureBox1.Width;
            int ikincikopegingenisligi = pictureBox2.Width;
            int ucuncukopegıngenisligi = pictureBox3.Width;
            int dorduncukopegıngenisligi = pictureBox4.Width;
            int bitisuzakligi = label1.Left;
            pictureBox1.Left += random.Next(5,15);
            pictureBox2.Left += random.Next(5, 15);
            pictureBox3.Left += random.Next(5, 15);
            pictureBox4.Left += random.Next(5, 15);

            if (birinicikopegingenisligi + pictureBox1.Left >= bitisuzakligi) {
                timer1.Enabled = false;  MessageBox.Show("Tombiş kazandı."); kimkazandı.Text = "Tombiş"; 
              
            
            
            
            }
            if (ikincikopegingenisligi + pictureBox2.Left >= bitisuzakligi) { timer1.Enabled = false; MessageBox.Show("Fırtına Yarışı Kazandı."); kimkazandı.Text = "Fırtına"; }
            if (ucuncukopegıngenisligi + pictureBox3.Left >= bitisuzakligi) { timer1.Enabled = false; MessageBox.Show("Dobi Yarışı Kazandı."); kimkazandı.Text = "Dobi"; }
            if (dorduncukopegıngenisligi + pictureBox4.Left >= bitisuzakligi) { timer1.Enabled = false; MessageBox.Show("Prenses Yarışı Kazandı."); kimkazandı.Text = "Prenses"; }
            //*************************
            if (timer1.Enabled == false) { 
            if (Secim1 != null) {
                if (Secim1==kimkazandı.Text) { gurkanbakiye += bahis1; } else { gurkanbakiye -= bahis1; }
                radioButton1.Text = "Gürkan " +gurkanbakiye+" TL'ye Sahip.";
            }
            if (Secim2 != null)
            {
                if (Secim2 == kimkazandı.Text) { alibakiye += bahis2; } else { alibakiye -= bahis2; }
                radioButton2.Text = "Ali " + alibakiye + " TL'ye Sahip.";
            }
            if (Secim3 != null)
            {
                if (Secim3 == kimkazandı.Text) { göktürkbakiye += bahis3; } else { göktürkbakiye -= bahis3; }
                radioButton3.Text = "Göktürk " + göktürkbakiye + " TL'ye Sahip.";
            }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Text = "Gürkan";
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Text = "Ali";
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Text = "Göktürk";
        }

        public void button2_Click(object sender, EventArgs e)
        {
         
            if (label6.Text=="Gürkan") {
                label7.Text = "Gürkan "+comboBox1.Text+" adlı köpeğe "+textEdit1.Text+" TL bahis oynadı.";
                Secim1 = comboBox1.Text;
                Bahis1 = Convert.ToInt32(textEdit1.Text);
              
            }
            if (label6.Text == "Ali") {
                label8.Text = "Ali " + comboBox1.Text + " adlı köpeğe " + textEdit1.Text + " TL bahis oynadı.";
                Secim2 = comboBox1.Text;
                Bahis2 = Convert.ToInt32(textEdit1.Text);

            }
            if (label6.Text == "Göktürk") {
                label9.Text = "Göktürk " + comboBox1.Text + " adlı köpeğe " + textEdit1.Text + " TL bahis oynadı.";
                Secim3 = comboBox1.Text;
                Bahis3 = Convert.ToInt32(textEdit1.Text);


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
