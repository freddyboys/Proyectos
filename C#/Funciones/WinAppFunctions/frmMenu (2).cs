using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAppFunctions
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCuadraticFuction_Click(object sender, EventArgs e)
        {
            frmCuadraticFunction ObjFrm = new frmCuadraticFunction();
            ObjFrm.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn4petals_Click(object sender, EventArgs e)
        {
            frmRoseFourPetals ObjFrm = new frmRoseFourPetals();
            ObjFrm.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSeno ObjFrm = new frmSeno();
            ObjFrm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCoseno ObjFrm = new frmCoseno();
            ObjFrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTangente ObjFrm = new frmTangente();
            ObjFrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFuncion ObjFrm = new frmFuncion();
            ObjFrm.Show();
        }
    }
}
