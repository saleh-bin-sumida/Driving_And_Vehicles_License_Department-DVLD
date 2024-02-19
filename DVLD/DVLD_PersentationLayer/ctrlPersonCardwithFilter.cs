using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonCardwithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null) 
            {
                handler(PersonID);
            }
        }

        public string PersonID { get { return ctrlPersonCard1.PersonID; } }


        
        public ctrlPersonCardwithFilter()
        {
            InitializeComponent();
        }

     
        public void HideFilter()
        {
            gbxPersonFilter.Hide();
        }

        private void AddnewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.SendDataBack +=  _LoadPersonCardwithFilterData;
            frm.ShowDialog();
        }


        public void _LoadPersonCardwithFilterData(int PersonID)
        {
            cbxFilter.SelectedIndex = 0;
            txtFilterExpressions.Text = PersonID.ToString();
            ctrlPersonCard1.LoadData(clsPerson.FindPersonByID(PersonID));
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtFilterExpressions.Text == "")
                return;

            clsPerson Person = new clsPerson();
            

            if (cbxFilter.SelectedItem.ToString() == "PersonID")
            {

                if (!clsPerson.IsPersonExists(int.Parse(txtFilterExpressions.Text)))
                {
                    MessageBox.Show("Person With this ID doesnt exsits!", "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Person = clsPerson.FindPersonByID(int.Parse(txtFilterExpressions.Text));
            }
            else
            {
                if (!clsPerson.IsPersonExists(txtFilterExpressions.Text))
                {
                    MessageBox.Show("Person With this National No. doesnt exsits!", "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Person = clsPerson.FindPersonByNationalNo(txtFilterExpressions.Text);
            }


            ctrlPersonCard1.LoadData(Person);

            OnPersonSelected.Invoke(Person.PersonID);


        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterExpressions.Text = "";
            ctrlPersonCard1.Clear();
        }

        private void txtFilterExpressions_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterExpressions.Text == "")
            {
                ctrlPersonCard1.Clear();
            }
        }

        private void ctrlPersonCardwithFilter_Load(object sender, EventArgs e)
        {
            cbxFilter.DataSource = new string[] { "PersonID", "NationalNo" };
        }

        private void txtFilterExpressions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedItem.ToString() == "PersonID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
