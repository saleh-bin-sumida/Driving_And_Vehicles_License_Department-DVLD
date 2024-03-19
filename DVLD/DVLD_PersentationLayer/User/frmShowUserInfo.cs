using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowUserInfo : Form
    {
        int _UserID;
        clsUser User;
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void frmShowUserInfo_Load(object sender, System.EventArgs e)
        {
            User = clsUser.FindUserBy(_UserID);
            ctrlPersonCard1.LoadData(User._person);
            ctrlLoginInfo1.LoadData(User);
        }
    }
}
