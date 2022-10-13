public abstract class Guest
{
    private string PrefixName;
    private string Name;
    private string Surname;
    private int Age;
    private string Allergy;
    private string Religion;

    public Guest(string PrefixName, string Name,  string Surname, int Age, string Allergy, string Religion){
              this.PrefixName = PrefixName;
              this.Name = Name;
              this.Surname = Surname;
              this.Age = Age;
              this.Allergy = Allergy;
              this.Religion = Religion;  
    }
    public string GetPrefixName(){
        return this.PrefixName;
    }
    public string GetName(){
        return this.Name;
    }
    public string GetSurname(){
        return this.Surname;
    }
    public int GetAge(){
        return this.Age;
    }
    public string GetAllergy(){
        return this.Allergy;
    }
    public string GetReligion(){
        return this.Religion;
    }
}