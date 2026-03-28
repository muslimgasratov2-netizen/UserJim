using System.ComponentModel;

namespace Project;

class User
{
    public string  UserName { get; set; } = string.Empty;

    public string  Password { get; set; } = string.Empty;


    public string  Email { get; set; } = string.Empty;

    public User(string name, string email, string password)
    {
        UserName = name;
        Email = email;
        Password = password;
        System.Console.WriteLine($"{UserName} создан");
        
    }

    public User() : this("Данил Колбасенко", "danyagig@gmail.com", "12345678") {}

    public void Say(string msg)
    {
        System.Console.WriteLine($"{UserName} : {msg}");
    }
    public override string ToString() => $"Username: {UserName}\nEmail: {Email}\n";
    
        
    
        
    
}



