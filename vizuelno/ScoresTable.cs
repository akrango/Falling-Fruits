using FallingFruits.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingFruits
{
    public partial class ScoresTable : Form
    {
        UserDBContext db = new UserDBContext();
        FallingFruits FallingFruits;
        public ScoresTable(Form Fruits)
        {
            InitializeComponent();
            PopluateTable();
            StyleTable();
            FallingFruits = (FallingFruits)Fruits;
        }

        public void PopluateTable()
        {
            var Users = db.Users
                .OrderByDescending(user => user.Score)
                .Select(user => new { user.Name, user.Score })
                .ToList();

            scoreTable.Columns.Add("", "");
            scoreTable.Columns.Add("Name", "Name");
            scoreTable.Columns.Add("Score", "Score");
            int i = 1;
            string place = "";
            foreach (var User in Users)
            {
                switch (i)
                {
                    case 1: place = "1ST"; break;
                    case 2: place = "2ND"; break;
                    case 3: place = "3RD"; break;
                    default: place = ""; break;
                }
                i++;
                scoreTable.Rows.Add(place, User.Name, User.Score);
            }
        }

        public void StyleTable()
        {
            this.BackColor = Color.Lavender;
            scoreTable.BackgroundColor = Color.Lavender;
            scoreTable.Font = new Font("MS Gothic", 12, FontStyle.Bold);
            scoreTable.ForeColor = Color.SteelBlue;
            scoreTable.BorderStyle = BorderStyle.None;
        }
    }
}
