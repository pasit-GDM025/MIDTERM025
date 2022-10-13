public class Student: Guest{
    private string SchoolLevel;
    private string School;

    public Student(string PrefixName, string Name, string Surname, int Age, string Allergy, string Religion, string SchoolLevel, string School)

            :base(PrefixName, Name, Surname, Age, Allergy, Religion){
                this.SchoolLevel = SchoolLevel;
                this.School = School;
    }
}