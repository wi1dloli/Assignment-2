namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //These are the variables for responses on certain conditions of the program
        private const string LockedOutWarn = "No more tries left. You've been locked out.";
        private const string PaymentWarn = "A payment method must be selected to log in.";
        private const string LoginTip = "Click here to log in!";
        private string ActiveTooltip = PaymentWarn;
        private uint loginAttempts = 1;
        private uint TriesLeft = 3;


        //If no payment type is selected, Log In button will be disabled until payment type is selected.
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                button1.Enabled = true;
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                button1.Enabled = true;
            }
        }

        //Code for Logging In button is found below
        private void button1_Click(object sender, EventArgs e)
        {
            //Variables for Username and Password
            string userName = "Jayden";
            string passWord = "Ahhh";

            //Verifying both username and password are correct
            if (textBox1.Text == userName && textBox2.Text == passWord)
            {
                MessageBox.Show("Welcome to your account " + userName + "!", "Authorization complete!");
                loginAttempts = 1;
            }
            //If login attempts exceed 3 tries, button will be locked
            else if (loginAttempts == 3)
            {
                MessageBox.Show(LockedOutWarn, "Authorization Failed.");
                button1.Enabled = false;

            }
            //If username or password are incorrect, attemps increase and tries left decreases.
            else if (textBox1.Text != userName || textBox2.Text != passWord)
            {
                loginAttempts += 1;
                TriesLeft -= 1;
                MessageBox.Show("Username or Password is Incorrect." + "\n" + "Attempts Remaining: " + TriesLeft);
            }
        }

        //If no payment type is selected, a button hover popup warning will insure payment method is selected
        private void button1_Mousehover(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show(ActiveTooltip);
                button1.Enabled = false;

            if (radioButton1.Checked == true || radioButton2.Checked == true)
                button1.Enabled=true;
        }



        //Other Tools
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

