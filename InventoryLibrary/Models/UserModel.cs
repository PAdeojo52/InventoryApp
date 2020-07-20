namespace InventoryLibrary
{
    public class UserModel
    {
        private int UserID;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double FineAmount { get; set; }
        public int Admin { get; set; }
        public string Password { get; set; }



        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        public UserModel(/*int userID,*/ string firstName, string lastName, string email, string phoneNumber, double fineAmount, int admin, string pw)
        {
            //UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            this.FineAmount = fineAmount;
            Admin = admin;
            Password = pw;
        }

       

        //public int UserID1 { get => UserID; set => UserID = value; }
        
    }
}