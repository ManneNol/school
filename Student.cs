namespace App;

class Student : IUser
{
    public string Email;
    string _password; // private by default

    public Student(string email, string password)
    {
        Email = email;
        _password = password;
    }

    public bool TryLogin(string username, string password)
    {
        return username == Email && password == _password;
    }

    public bool IsRole(Role role)
    {
        return Role.Student == role;
    }

    public Role GetRole()
    {
        return Role.Student;
    }
}

