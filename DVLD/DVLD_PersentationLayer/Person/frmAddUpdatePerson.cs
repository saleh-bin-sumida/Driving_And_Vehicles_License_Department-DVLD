using System;
using DVLD_BusinessLayer;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace DVLD
{
    public partial class frmAddUpdatePerson : Form
    {
        enum Mode { AddNew = 1, Update = 2}
        Mode mode;

        public delegate void SendDataBackHandler(int obj);

        public SendDataBackHandler SendDataBack;

        private clsPerson _Person;

        int _PersonID;
        public frmAddUpdatePerson(int personID)
        {
            this._PersonID = personID;

            if (_PersonID == -1)
                mode = Mode.AddNew;
            else
                mode = Mode.Update;


            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            // initialzie form controls
            cbxCountries.DataSource = clsCountry.GetAllCountries();
            cbxCountries.DisplayMember = "CountryName";
            pbxInValidNationalNo.Visible = false;
            pbxEmailValidation.Visible = false;
            lblRemoveImage.Visible = false;

            

            if (mode == Mode.AddNew)
            {
                _Person = new clsPerson();

                lblFromHeading.Text = "Add New Person";
                lblPersonIDLabel.Visible = false;
                lblPersonIDValue.Visible = false;
                txtFirstName.Text = "";
                txtSecondName.Text ="";
                txtThirdName.Text = "";
                txtLastName.Text = "";
                txtNationalNo.Text = "";
                rdMale.PerformClick();
                dateTimePicker.MaxDate =  DateTime.Now.AddYears(-18) ;
                txtPhone.Text = "";
                txtEmail.Text = "";
                cbxCountries.SelectedIndex = _Person.NationalityCountryID -1;
                txtAddress.Text = "";
                _setDefualtImage();

                return;
            }


             // ------------------------------------------- update mode

            _Person = clsPerson.FindPersonByID(_PersonID);
            lblFromHeading.Text = "Update Person Info";
            lblPersonIDLabel.Visible = true;
            lblPersonIDValue.Visible = true;

            
            lblPersonIDValue.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dateTimePicker.Value = _Person.DateOfBirth;
            if (_Person.Gender == 1)
            {
                rdMale.PerformClick()  ;
            }
            else
            {
                rdFemale.PerformClick();
            }

            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbxCountries.SelectedIndex = _Person.NationalityCountryID -1;
            txtAddress.Text = _Person.Address;
            pictureBox1.Image = _setPersonImage(_Person.ImagePath);
         


        }


        private Image _setPersonImage(string ImagePath)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(ImagePath);
                lblRemoveImage.Visible = true;
            }
            catch (Exception e)
            {
                _setDefualtImage();
                Util.LogError(e.Message);

            }
            return pictureBox1.Image;
        }

        private void _setDefualtImage()
        {
            if ( rdMale.Checked)
                pictureBox1.Image = DVLD.Properties.Resources.Male;
            else if (rdFemale.Checked)
                pictureBox1.Image = DVLD.Properties.Resources.Female;


            lblRemoveImage.Visible = false;
        }


        private void txtFullnameBoxes_keyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _tooltipCustom(ToolTip tool,Control sender, string text)
        {
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 500;
            tool.SetToolTip(sender, text);
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (text == _Person.NationalNo)
                return;

            if (clsPerson.IsPersonExists(text))
            {
                ToolTip tool = new ToolTip();
                _tooltipCustom(tool, pbxInValidNationalNo, "this National No. already taken");
                ((TextBox)sender).ForeColor = Color.Red;
                pbxInValidNationalNo.Visible = true;
                return;
            }

            pbxInValidNationalNo.Visible = false;
            ((TextBox)sender).ForeColor = Color.Black;

        }

        private bool _isAllFieldsValid(ref string ErrorMessage)
        {
            if (pbxInValidNationalNo.Visible)
            {
                ErrorMessage = "This National No already taken, choose another one.";
                return false;
            }
            if (pbxEmailValidation.Visible)
            {
                ErrorMessage = "Incorrect Email. write a valid email.";
                return false;
            }
            if (txtFirstName.Text == "" || txtSecondName.Text == "" || txtThirdName.Text == "" || txtLastName.Text == ""
                || txtPhone.Text  == "" || txtAddress.Text == "")
            {
                ErrorMessage = "Please Fill all the fields!";
                return false;
            }
            return true; 
        }

        private void SavePerson_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (!_isAllFieldsValid(ref ErrorMessage))
            {
                MessageBox.Show(ErrorMessage,"Invalid Feild",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            
            _Person.NationalNo = txtNationalNo.Text;
            _Person.Address = txtAddress.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.DateOfBirth = dateTimePicker.Value;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.NationalityCountryID = cbxCountries.SelectedIndex +1 ;
            if (rdMale.Checked)
                _Person.Gender = 1;
            else
                _Person.Gender = 0;



        
            if (mode == Mode.AddNew)
            {
                if (_Person.Save())
                {
                    MessageBox.Show("Person Addtion went Succefully", "Adding Person");
                    mode = Mode.Update;
                    lblFromHeading.Text = "Updating Person";
                    lblPersonIDLabel.Visible = true;
                    lblPersonIDValue.Visible = true;
                    lblPersonIDValue.Text = _Person.PersonID.ToString();

                    return;
                }
                MessageBox.Show("Something went wronge, Person Addition didnt Succed", "Adding Person");

            }
            else
            {
                if (_Person.Save())
                {
                    MessageBox.Show("Person info Updated Succefully", "Updating  Person");           
                    return;
                }
                MessageBox.Show("Something went wronge, Updation Person Info didnt Succed", "Updating Person");
            }
            

        }


        private void CheckMaleOrFemale(object sender, EventArgs e)
        {
         
            if (_Person.ImagePath != "")
                return;
            _setDefualtImage();
        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                openFileDialog.Title = "Select an Image File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    if (_Person.ImagePath != "" && File.Exists(_Person.ImagePath))
                    {
                        _DeleteImage();

                    }
                    if (File.Exists(imagePath))
                    {
                        string destinationFolder = GlobalSettings.destinationFolder;
                        string fileExtension = Path.GetExtension(imagePath);

                        string fileName = Guid.NewGuid().ToString() + fileExtension;
                        string destinationPath = Path.Combine(destinationFolder, fileName);
                        File.Copy(imagePath, destinationPath, true);
                        _Person.ImagePath = destinationPath;
                        pictureBox1.Image = Image.FromFile(_Person.ImagePath);

                        lblRemoveImage.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("The specified image file does not exist.");
                    }
                }
            }
        }


        private void _DeleteImage()
        {
            try
            {
                pictureBox1.Image.Dispose();
                _setDefualtImage();
                File.Delete(_Person.ImagePath);
                _Person.ImagePath = "";

            }
            catch (Exception e)
            {
                pictureBox1.Image = Image.FromFile(_Person.ImagePath);
                MessageBox.Show("unable to delete picture, Its in use by other process", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Util.LogError(e.Message);

            }
        }

        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!string.IsNullOrEmpty(_Person.ImagePath))
                _DeleteImage();
        }

        private void Close_click(object sender, EventArgs e)
        {
            SendDataBack?.Invoke(_Person.PersonID);
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                pbxEmailValidation.Visible = false;
                return;
            }

            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Regex emailRegex = new Regex(emailPattern);
            if (emailRegex.IsMatch(txtEmail.Text))
            {
                pbxEmailValidation.Visible = false;
            }
            else
            {
                ToolTip tool = new ToolTip();
                _tooltipCustom(tool, pbxEmailValidation, "invalid email");
                pbxEmailValidation.Visible = true;

            }
        }
    }
}
