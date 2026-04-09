using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG_282_Project.DataLayer;

namespace PRG_282_Project
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStudentForm newStudentForm = new NewStudentForm();
            newStudentForm.Show();
            this.Hide();




        }
    }
}
