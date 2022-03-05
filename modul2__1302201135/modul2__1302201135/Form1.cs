namespace modul2__1302201135
{
    public partial class Form1 : Form
    {
        double value = 0;
        string ops = "";
        bool op_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            if ((hasil.Text == "0") || (op_pressed))
            {
                hasil.Clear();
            }
            Button b = (Button)sender;

            hasil.Text = hasil.Text + b.Text;
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ops = b.Text;
            value = Double.Parse(hasil.Text);

            op_pressed = true;
        }

        private void jumlah_Click(object sender, EventArgs e)
        {
            switch (ops)
            {
                case "+": hasil.Text = (value + Double.Parse(hasil.Text)).ToString();
                    break;
            }
        }
    }
}