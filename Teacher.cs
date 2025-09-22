namespace App;

class Teacher : IUser
{
    public string Username;
    string _password; // private by default

    public Teacher(string username, string password) // constructor
    {
        Username = username;
        _password = password;
    }

    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }

    public bool IsRole(Role role)
    {
        return Role.Teacher == role;
    }

    public Role GetRole()
    {
        return Role.Teacher;
    }
}
