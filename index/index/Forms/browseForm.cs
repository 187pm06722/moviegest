using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index.Forms
{
    public partial class browseForm : Form
    {
        public browseForm()
        {
            InitializeComponent();
            this.btnAddNewMovie.Click += BtnAddNewMovie_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnAddToFavorite.Click += BtnAddToFavorite_Click;
        }

        private void BtnAddNewMovie_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel successfully.", "Cancel Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }

        private void BtnAddToFavorite_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
