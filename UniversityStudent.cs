public class UniversityStudent: Admin{
    private string UniversityID;

    public UniversityStudent(string PrefixName, string Name, string Surname, int Age, string Allergy, string Religion, string UniversityID, char IsAdmin, string AdminGmail, string AdminPassword)
    
    :base(PrefixName, Name, Surname, Age, Allergy, Religion, IsAdmin, AdminGmail, AdminPassword) {

        this.UniversityID = UniversityID;
    }
}