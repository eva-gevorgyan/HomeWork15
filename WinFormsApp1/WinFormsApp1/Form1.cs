namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hour, minute, second;
        int alarmHor, alarmMinute;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            for (int i = 0; i <= 24; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int i = 0; i <= 60; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            alarmHor = int.Parse(comboBox1.Text);
            alarmMinute = int.Parse(comboBox2.Text);
            label1.Text = $"{alarmHor}:{alarmMinute}";

            if (alarmHor == hour && alarmMinute == minute && second == 0)
            {
                MessageBox.Show("End");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;

            label2.Text = hour.ToString();
            label3.Text = minute.ToString();
            label4.Text = second.ToString();
        }
    }
}
