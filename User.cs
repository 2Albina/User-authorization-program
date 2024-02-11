using System;
using System.Security.Policy;
using Newtonsoft.Json;

namespace DP1
{
    public class User
    {
        public readonly string Name;
        public readonly string Password;
        public readonly bool IsBlocked;
        public readonly bool HasPasswordLimitations;

        public User(string name, string password, bool isBlocked, bool hasPasswordLimitations)
        {
            Name = name;
            Password = password;
            IsBlocked = isBlocked;
            HasPasswordLimitations = hasPasswordLimitations;
        }

        public static User CreateEmpty(string name)
        {
            return new User(name, PasswordManager.Hash(""), false, true);
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static User FromJson(string json)
        {
            var user = JsonConvert.DeserializeObject<User>(json);
            return user;
        }
    }
}