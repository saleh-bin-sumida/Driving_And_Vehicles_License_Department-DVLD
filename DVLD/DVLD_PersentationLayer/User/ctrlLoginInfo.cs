using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlLoginInfo : UserControl
    {
        public int UserID {get { return int.Parse(_UserID.Text); }}

        public string Username { get { return _Username.Text; } }

        public bool IsActive { get { return bool.Parse(_IsActive.Text); } }

        public ctrlLoginInfo()
        {
            InitializeComponent();
        }

        public void LoadData(clsUser User)
        {
            if (User == null)
                return;
            _UserID.Text = User.UserID.ToString();
            _Username.Text = User.Username;
            _ =(User.IsActive ? _IsActive.Text = "Active" : _IsActive.Text = "Not Active");
        }

        public void Clear()
        {
            _UserID.Text = "";
            _Username.Text = "";
            _IsActive.Text = "";
        }
    }
}
