using System.Data;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        enum Mode {AddNew = 1, Update = 2}
        Mode mode;

        public clsPerson _person { get; set; }
        public int UserID { get; private set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }



        public clsUser()
        {
            mode = Mode.AddNew;

            _person = new clsPerson();
            this.UserID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
        }

        private clsUser(int UserID,int PersonID, string Username, string Password, bool IsActive)
        {
            mode = Mode.Update;

            _person = clsPerson.FindPersonByID(PersonID);
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
        }


        public static clsUser FindUserBy(string Username, string Password)
        {
            int PersonID = 0, UserID = 0;
            bool IsActive = false;

            string HashedPassword = Util.ComputeHashing(Password);


            if (clsUser_Data.GetUserByUsernameAndPassword(Username, HashedPassword, ref UserID, ref PersonID, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            }
            return null;
        }


        public static clsUser FindUserBy(int UserID)
        {
            int PersonID = 0;
            string Username = "", Password = "";
            bool IsActive = false;

            if (clsUser_Data.GetUserByID(UserID,ref  Username, ref Password, ref PersonID, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            }
            return null;
        }


        private bool _AddUser()
        {
            this.UserID = clsUser_Data.AddNewUser(this._person.PersonID, this.Username, this.Password, this.IsActive);
            return UserID != -1;
        }

        private bool _UpdateUser() => clsUser_Data.UpdateUserInfo(this.UserID,this._person.PersonID, this.Username, this.Password, this.IsActive);
           

        public static bool DeleteUser(int UserID) =>  clsUser_Data.DeleteUser(UserID);


        public static DataTable GetAllUsers() => clsUser_Data.GetAllUsers();

        public bool Save()
        {
            switch (this.mode)
            {
                case Mode.AddNew:
                    mode = Mode.Update;
                    return _AddUser();
                case Mode.Update:
                    return _UpdateUser();

            }

            return false;
        }


    }

}
