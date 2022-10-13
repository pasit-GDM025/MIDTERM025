public class Teacher: Admin{

    private string JobPosition;
    private char HaveCar;
    private string CarRegistration;

    public Teacher(string PrefixName, string Name, string Surname ,int Age, string Allergy, string Religion, string JobPosition, char HaveCar, string CarRegistration, char IsAdmin, string AdminGmail, string AdminPassword)

   :base(PrefixName, Name, Surname, Age, Allergy, Religion, IsAdmin, AdminGmail, AdminPassword){

        this.JobPosition = JobPosition;
        this.HaveCar = HaveCar;
        this.CarRegistration = CarRegistration;
    }
}