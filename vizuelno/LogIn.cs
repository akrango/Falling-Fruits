using FallingFruits.Models;
using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Windows.Forms;


namespace FallingFruits
{
    public partial class LogIn : Form
    {
        FallingFruits Form1;
        UserDBContext db;
        public User user;
        public LogIn()
        {
            InitializeComponent();
            db = new UserDBContext();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == string.Empty)
            {
                return;
            }
            user = db.Users.FirstOrDefault(user => user.Name == tbUsername.Text);
            if (user == null)
            {
                user = new User();
                user.Name = tbUsername.Text;
            }
            Form1 = new FallingFruits(user, this);
            Form1.Show();
            this.Hide();
        }
    }
}
