using System.Xml.Linq;

namespace GettingStarted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult choice =
               MessageBox.Show("Are you sure you want to Exit?", "Attention",
                   MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                lblValidFName.Text = "Enter a valid First Name";
            }
            else
            {
                lblValidFName.Text = "*";
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                lblValidLName.Text = "Enter a valid Last Name";
            }
            else
            {
                lblValidLName.Text = "*";
            }
            if (lblValidFName.Text == "*" && lblValidLName.Text == "*")
            {
                MessageBox.Show($"Hello {txtFirstName.Text + " " + txtLastName.Text}, you submited successfully");
            }
                    
        }
    }
}
