using System.Configuration;

namespace COMP1551___Coursework
{
    public partial class Form1 : Form
    {
        //Public property to store the logged-in role
        #pragma warning disable WFO1000
        public string LoggedInRole { get; private set; } = string.Empty;
        #pragma warning restore WFO1000
        public Form1()
        {
            InitializeComponent();
            this.Text = "Login Form";
            this.Size = new System.Drawing.Size(600, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ECS001")
            {
                LoggedInRole = "student";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           else if(textBox1.Text == "ECT001")
            {
                LoggedInRole = "teacher";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(textBox1.Text == "ECA001")
            {
                LoggedInRole = "admin";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                label1.Text = "Invalid Code";
                return;
            }
        }
    }
}