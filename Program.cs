using System;
enum Menu{
    GuestRegistration = 1,
    StatGuest = 2,
    Login = 3 ,
}
enum GuestMenu{
    UniversityStudentRegister = 1,
    StudentRegister = 2,
    TeacherRegister = 3
}
enum LoginMenu{
    UnistudentonlyList = 1,
    StudentonlyList = 2,
    TeacheronlyList = 3
}
class Program{
    static GuestList guestList;

    public static void Main(string[]args){
        PrepareGuestList();
        PrintListMenu();
        InputMenuFromKeyboard();
    }
    public static void PrepareGuestList(){
        Program.guestList = new GuestList();
    }
    public static void PrintMenuScreen(){
        Console.Clear();
        PrintListMenu();
    }
    public static void PrintListMenu(){
        Console.Clear();
        Console.WriteLine("Welcome to Idea camp registration \n Menu: ");
        Console.WriteLine("1. Guest Registration");
        Console.WriteLine("2. Stat Guest");
        Console.WriteLine("3. Log in ");
        Console.WriteLine("=================================");
    }

    public static void InputMenuFromKeyboard(){
        Console.Write("Choose: \n");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PrintMenu(menu);
    }
    public static void PrintMenu(Menu menu){
        switch(menu)
        {
            case Menu.GuestRegistration :
            ShowNewGuestRegister();
            break;
            case Menu.StatGuest :
            ShowStatGuest();
            break;
            case Menu.Login :
            ShowLoginScreen();
            break;
            default :
            break;
        }
    }
    public static void ShowNewGuestRegister(){
        Console.Clear();
        Console.WriteLine("Guest Register");
        Console.WriteLine("You are: =====");
        Console.WriteLine("1. University Student \n 2. Student \n 3.Teacher");
        Console.WriteLine("Choose:");
        GuestMenu subMenu = (GuestMenu)(int.Parse(Console.ReadLine()));

        PrintGuestSubMenu(subMenu);
        
    }
    public static void PrintGuestSubMenu(GuestMenu submenu){
          switch(submenu){
            case GuestMenu.UniversityStudentRegister :
            ShowUniversityStudentInfoInputScreen();
            break;
            case GuestMenu.StudentRegister :
            ShowStudentInfoInputScreen();
            break;
            case GuestMenu.TeacherRegister :
            ShowTeacherInfoInputScreen();
            break;
        }
    }
    public static int TotalGuestUniversitystudent(){
        Console.Clear();
        Console.WriteLine("Input total University Student as guest:");
        return int.Parse(Console.ReadLine());
    }
    
    public static void InputGuestUniversityStudentFromKeyBoard(int TotalGuestUniversityStudent){

        for(int i =0; i < TotalGuestUniversityStudent; i++){
            Console.Clear();
        Console.WriteLine("University Student Information input:");
        Console.WriteLine("====================================");

        UniversityStudent universitystudent = new UniversityStudent(InputPrefixName(), InputName(), InputSurname(), InputAge(), InputAllergy(), InputReligion(), InputUniversityID(), InputIsAdmin(), InputAdminGmail(), InputAdminPassword());
        Program.guestList.AddNewGuest(universitystudent);
        }
        BackToMenu();    
    }

    public static string InputPrefixName(){
        Console.Write("Prefix input: \n 1.Mr. \n 2.Mrs. \n 3.Miss \n Other \n");
        int Prefix = int.Parse(Console.ReadLine());
        if(Prefix == 1){
            return "Mr.";
        }
        else if (Prefix == 2){
            return "Mrs.";
        }
        else if (Prefix == 3){
            return "Miss";
        }
        else if (Prefix == 4){
            return "Other";
        }
        else{
            return "Invalid Name prefix";
        }
        
    }
    public static string InputName(){
        Console.WriteLine("Name:");
        return Console.ReadLine();
    }
    public static string InputSurname(){
        Console.WriteLine("Surname:");
        return Console.ReadLine();
    }
    public static int InputAge(){
        Console.WriteLine("Age:");
        return int.Parse(Console.ReadLine());
    }
    public static string InputAllergy(){
        Console.WriteLine("Allergy:");
        return Console.ReadLine();
    }
    public static string InputReligion(){
        Console.WriteLine("Religion: \n 1.Buddhism \n 2.Christian \n 3.islam \n 4.Other \n");
        int Religion = int.Parse(Console.ReadLine());
        if(Religion == 1){
            return ("Buddhism");
        }
        else if (Religion == 2){
            return ("Christian");
        }
        else if (Religion == 3){
            return ("islam");
        }
        else if (Religion == 4){
            return ("Other");
        }
        else{
            return ("Invalid religion");
        }
    }
    public static string InputUniversityID(){
        Console.WriteLine("University ID:");
        return Console.ReadLine();
    }
    public static string InputSchoolLevel(){
        Console.WriteLine("School level: \n 1. M.4 \n 2. M.5 \n 3. M.6");
        int schoollevel = int.Parse(Console.ReadLine());
        if(schoollevel == 1 ){
            return ("M.4");
        }
        else if (schoollevel == 2){
            return ("M.5");
        }
        else if (schoollevel == 3){
            return ("M.6");
        }
        else{
            return ("There's not M.7 this is 2022 my man");
        }
    }
    public static string InputSchool(){
        Console.WriteLine("School name:");
        return Console.ReadLine();
    }
    public static string InputJobPosition(){
        Console.WriteLine("Job position: \n 1.Dent \n 2.Head department \n 3.Full time teacher \n");
        int JobPoInput = int.Parse(Console.ReadLine());

        if(JobPoInput == 1){
            return ("Dent");
        }
        else if (JobPoInput == 2){
            return ("head department");
        }
        else if (JobPoInput == 3){
            return ("Full time teacher");
        }
        else {
            return ("Invalid job Position");
        }
    }
    public static char InputHavecar(){
        Console.WriteLine("Have car : Y/N");
        return char.Parse(Console.ReadLine());
    }
    public static string InputCarregistration(){
        Console.WriteLine("Car registration(if don't have press X):");
        return Console.ReadLine();
    }
    public static char InputIsAdmin(){
        Console.WriteLine("Admin? Y/N");
        return char.Parse(Console.ReadLine());
    }
    public static string InputAdminGmail(){
        Console.WriteLine("Input Gmail (if not admin write -)");
        return Console.ReadLine();
    }
    public static string InputAdminPassword(){
        Console.WriteLine("Input Passwordif not admin write -");
        return Console.ReadLine();
        }
    public static void ShowUniversityStudentInfoInputScreen(){
       
        int totalGuestUni = TotalGuestUniversitystudent();
        
        InputGuestUniversityStudentFromKeyBoard(totalGuestUni);
    }
    
    public static int TotalGuestStudent(){
        Console.Clear();
        Console.WriteLine("Input total Student as guest");
        return int.Parse(Console.ReadLine());
    }
    public static void InputGuestStudentFromKeyBoard(int TotalGuestStudent){
         for(int i =0; i < TotalGuestStudent; i++){
            Console.Clear();
        Console.WriteLine("Student Information input:");
        Console.WriteLine("====================================");

        Student student = new Student(InputPrefixName(), InputName(), InputSurname(), InputAge(), InputAllergy(), InputReligion(), InputSchoolLevel(), InputSchool());
        Program.guestList.AddNewGuest(student);
        }
        BackToMenu();
    }
    public static void ShowStudentInfoInputScreen(){
        int totalGuestStu = TotalGuestStudent();
        InputGuestStudentFromKeyBoard(totalGuestStu);
    }
    public static int TotalGuestTeacher(){
        Console.Clear();
        Console.WriteLine("Input total Teacher as guest");
        return int.Parse(Console.ReadLine());
    }
    public static void InputGuestTeacherFromKeyboard(int TotalGuestTeacher){
        for(int i =0; i < TotalGuestTeacher; i++){
            Console.Clear();
        Console.WriteLine("Teacher Information input:");
        Console.WriteLine("====================================");

        Teacher teacher = new Teacher(InputPrefixName(), InputName(), InputSurname(), InputAge(), InputAllergy(), InputReligion(), InputJobPosition(), InputHavecar(), InputCarregistration(), InputIsAdmin(), InputAdminGmail(), InputAdminPassword());
        Program.guestList.AddNewGuest(teacher);
        }
        BackToMenu();
    }
    public static void ShowTeacherInfoInputScreen(){
        int totalGuestTeacher = TotalGuestTeacher();
        InputGuestTeacherFromKeyboard(totalGuestTeacher);
    }
    public static void ShowStatGuest(){
        Console.Clear();
        Console.WriteLine("Show Guest List");
        Console.WriteLine("===============");
        Program.guestList.ShowGuestList();


        Continuewatchstat();
    }
    public static void Continuewatchstat(){
        Console.WriteLine("Press 1 to continue / another article to end process ");
        int ContinueButton = int.Parse(Console.ReadLine()); 
        if(ContinueButton == 1){
            BackToMenu();
        }
        else {
            Console.WriteLine("End process");
        }
    }
    public static void ShowLoginScreen(){
        Console.Clear();
        Console.WriteLine("Log in Screen");
        Console.WriteLine("=============");

        Console.WriteLine("Input user:");
        string user = Console.ReadLine();
        Console.WriteLine("Input password:");
        string Password = Console.ReadLine();

        Console.WriteLine("==============================================================");
        Console.WriteLine("Guest registered Data detail");
        Console.WriteLine("============================");
        Console.WriteLine("1.University student only \n 2.student only \n 3.Teacher only \n");
        Console.WriteLine("Choose:");
        LoginMenu loginmenu = (LoginMenu)(int.Parse(Console.ReadLine()));
        
        PrintLoginListMenu(loginmenu);
    }
    
    public static void PrintLoginListMenu (LoginMenu loginmenu ){
        switch(loginmenu){
            case LoginMenu.UnistudentonlyList:
            ShowUnistudentonlyList();
            break;
            case LoginMenu.StudentonlyList:
            ShowStudentonlyList();
            break;
            case LoginMenu.TeacheronlyList:
            ShowTeacheronlyList();
            break;
            default:
            break;
        }
    }
    public static void ShowUnistudentonlyList(){
        Console.Clear();
        Console.WriteLine("University student registered:");
        Console.WriteLine("=============================");
        Program.guestList.ShowUniStudentList();
        
        Continuewatchstat();

    }
    public static void ShowStudentonlyList(){
        Console.Clear();
        Console.WriteLine("Student registered:");
        Console.WriteLine("==================");
        Program.guestList.ShowStudentList();
        
        Continuewatchstat();
    }
    public static void ShowTeacheronlyList(){
        Console.Clear();
        Console.WriteLine("Student registered:");
        Console.WriteLine("==================");
        Program.guestList.ShowTeacherList();

        Continuewatchstat();
    }
   
    public static void BackToMenu(){
        PrintListMenu();
        InputMenuFromKeyboard();
    }

}
