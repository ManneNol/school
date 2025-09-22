using App;
// Användare
// Resurser, Dolda baserade på roll
// Logga in
// Logga ut
// Skapa en användare om man är en Admin
// Se schema
// Lämna in uppgifter
// Få uppgifter rättade med betyg (betyg kan vara en ENUM)
//


// IUser, 

List<IUser> users = new List<IUser>();
users.Add(new Student("Jonathan@nodehill.com", "password123"));
users.Add(new Student("Max@nodehill.com", "password123"));
users.Add(new Student("Linus@nodehill.com", "password123"));
users.Add(new Student("Benjamin@nodehill.com", "password123"));
users.Add(new Admin("magdalena@nbi-handelsakademin.se", "password123"));
users.Add(new Teacher("manuel@nodehill.com", "password123"));

users.Add(new Admin("admin", "admin"));


IUser? active_user = null;
 
bool running = true;

while(running)
{
    Console.Clear();

    if(active_user == null)
    {
        Console.Clear();
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Clear();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.Clear();

        foreach(IUser user in users)
        {
            if(user.TryLogin(username, password))
            {
                active_user = user;
                break;
            }
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("--- School System ---");

        /*
        if(active_user.IsRole(Role.Admin))
        {
            Console.WriteLine("Welcome Admin");
        }
        if(active_user.IsRole(Role.Teacher))
        {
            Console.WriteLine("Welcome Teacher");
        }
        if(active_user.IsRole(Role.Student))
        {
            Console.WriteLine("Welcome Student");
        }
        */

        switch(active_user.GetRole())
        {
            case Role.Teacher:
                Console.WriteLine("Welcome Teacher");
            break;
            case Role.Student:
                Console.WriteLine("Welcome Student");
            break;
            case Role.Admin:
                Console.WriteLine("Welcome Admin");
            break;
            default: break;
        }

        Console.WriteLine("logout");
        string input = Console.ReadLine();
        switch(input)
        {
            case "logout":
                active_user = null;
            break;
        }
    }
}

Console.WriteLine("Program is done");
