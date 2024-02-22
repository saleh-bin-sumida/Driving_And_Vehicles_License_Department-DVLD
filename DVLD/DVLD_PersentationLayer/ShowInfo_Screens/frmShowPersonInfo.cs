using System;
using DVLD_BusinessLayer;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowPersonInfo : Form
    {
        int _personID;

        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            this._personID = personID;

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            if (_personID != -1) 
            {
                ctrlShowPersonInfo1.LoadData(clsPerson.FindPersonByID(this._personID));
                return;
            }
            ctrlShowPersonInfo1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
