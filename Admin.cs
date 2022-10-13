public abstract class Admin : Guest{
    private char IsAdmin;
    private string AdminGmail;
    private string AdminPassword;

   public Admin(string PrefixName, string Name, string Surname, int Age, string Allergy, string Religion, char IsAdmin, string AdminGmail, string AdminPassword)
   : base(PrefixName, Name, Surname, Age, Allergy, Religion){
    
        this.IsAdmin = IsAdmin;
        this.AdminGmail = AdminGmail;
        this.AdminPassword = AdminPassword;
   }
    public char GetAdmin(){
        return this.IsAdmin;
    }
    public string GetAdminGmail(){
        return this.AdminGmail; 
    }
    public string GetAdminPassword(){
        return this.AdminPassword;
    }
}
