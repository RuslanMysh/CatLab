using System.Windows.Forms;

namespace практика_5._06._24
{
    public partial class Form1 : Form
    {
        Cat cat = new Cat();
        public Form1()
        {
            InitializeComponent();
            cat.HP = 100;
            cat.Name = "Милый негр ребёнок";

            label3.Text = "Имя: " + cat.Name;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cat.Feed(5, pictureBox1, progressBar1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cat.Punish(5, pictureBox1, progressBar1, pictureBox2);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    public class Cat
    {
        
        
        public int HP { get; set; }
        public string Name { get; set; }

        string color = "Зелёный";
        public string Color{

            get
            {
                if (HP > 0)
                {
                    color = "Зелёный";
                    
                }
                if (HP <= 0)
                {
                    color = "Белый";
                }
                return color;
            }
        }
        public int age { get; set; }

        public void Feed(int foodCount, PictureBox pictureBox1, ProgressBar progressBar1)
        {
            HP += foodCount;
            progressBar1.Step = foodCount;
            progressBar1.PerformStep();
            if (Color == "Зелёный")
            {
                pictureBox1.Image = Properties.Resources.ребёнок;
            }
            else if (Color == "Белый")
            {
                pictureBox1.Image = Properties.Resources.беелый_кот;
            }
        }
        public void Punish(int hit, PictureBox pictureBox1, ProgressBar progressBar1, PictureBox pictureBox2)
        {           
            HP -= hit;
            progressBar1.Step = -hit;
            progressBar1.PerformStep();
            if (Color == "Зелёный")
            {
                pictureBox1.Image = Properties.Resources.ребёнок;
            }
            else if (Color == "Белый")
            {
                pictureBox1.Image = Properties.Resources.ребёнок;              
                pictureBox2.Visible = true;
                //Application.Exit();
            }
        }
    }
}
