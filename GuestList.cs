using System.Collections;
using System;

public class GuestList{
    private List<Guest> guestList;

    public GuestList(){
        this.guestList = new List<Guest>();
    }

    public void AddNewGuest(Guest guest){
        this.guestList.Add(guest);
    }

    public void ShowGuestList()
    {
        Console.WriteLine("Total Guest List");
        Console.WriteLine("================");

        foreach(Guest guest in this.guestList)
        {
            if(guest is UniversityStudent){
                Console.WriteLine("Name:{0} {1} {2} \n Age:{3} \n Status: Universitystudent \n", guest.GetPrefixName(), guest.GetName(), guest.GetSurname(), guest.GetAge());
            }
            else if (guest is Student){
                Console.WriteLine("Name:{0} {1} {2} \n Age:{3} \n Status: Student \n",guest.GetPrefixName(), guest.GetName(), guest.GetSurname(), guest.GetAge());
            }
            else if (guest is Teacher){
                Console.WriteLine("Name:{0} {1} {2} \n Age:{3} \n Status: Teacher \n",guest.GetPrefixName(), guest.GetName(), guest.GetSurname(), guest.GetAge());
            }
        }
    }
    public void ShowUniStudentList(){
           int count =1;    
        foreach(Guest guest in this.guestList){
            if(guest is UniversityStudent){
                Console.WriteLine("{4} Name:{0} {1} {2} \n Age:{3} \n Status: Universitystudent \n", guest.GetPrefixName(), guest.GetName(), guest.GetSurname(), guest.GetAge(), count++);
            }
        }
    }
    
    
    public void ShowStudentList(){
        int count =1;
        foreach(Guest guest in this.guestList){
            if (guest is Student){
                Console.WriteLine("{4} Name:{0} {1} {2} \n Age:{3} \n Status: Student \n",guest.GetPrefixName(), guest.GetName(), guest.GetSurname(), guest.GetAge(), count++);
            }
        }
    }
    public void ShowTeacherList(){
        int count =1;
        foreach(Guest guest in this.guestList){
            if (guest is Teacher){
                Console.WriteLine("{4} Name:{0} {1} {2} \n Age:{3} \n Status: Teacher \n",guest.GetPrefixName(), guest.GetName(), guest.GetSurname(), guest.GetAge(), count++);
            }
        }
    }
}
