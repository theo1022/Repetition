using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Core
{
    public class LoginManager
    {
        public bool NewUserRegistered(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            StoreNewUser(username, password);

            return true;
        }

        public void StoreNewUser(string username, string password)
        {
            var path = "D:\\Dokument\\skola\\Repetition\\C#-Inlamningsuppgift-2\\TestFile.txt";

            var newUserAsJsonString = $"{{ \"username\": \"{username}\", \"password\": \"{password}\", \"registrationDate\": \"{DateTime.Now}\" }}";

            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(newUserAsJsonString);
            }
        }

        public bool TryLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            foreach (string line in File.ReadLines("D:\\Dokument\\skola\\Repetition\\C#-Inlamningsuppgift-2\\TestFile.txt"))
            {
                using (var sr = new StreamReader("D:\\Dokument\\skola\\Repetition\\C#-Inlamningsuppgift-2\\TestFile.txt"))
                {
                    var jsonString = sr.ReadLine();
                    var user = JsonSerializer.Deserialize<User>(jsonString);

                    if (user.Username == username)
                    {
                        return (user.Password == password);
                    }
                }
            }

            return false;
        }
    }

    public class User
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("registrationDate")]
        public string RegistrationDate { get; set; }
    }
}
