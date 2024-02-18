
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageScreen : Form
    {
        public frmManageScreen()
        {
            InitializeComponent();
        }

        protected void cbxFilter_SelectedIndexChanged()
        {
            _ = (cbxFilter.SelectedItem.ToString() == "None") ? txtFilterExpressions.Visible = false : txtFilterExpressions.Visible = true;
            txtFilterExpressions.Text = "";
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
