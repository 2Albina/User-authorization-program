using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DP1
{
    public class UserRepository
    {
        private readonly string _pathToFile = "users.txt";

        public UserRepository()
        {
            CreateFileIfNotExists();
        }

        public UserRepository(string pathToFile)
        {
            _pathToFile = pathToFile;
            CreateFileIfNotExists();
        }

        private void CreateFileIfNotExists()
        {
            if (!File.Exists(_pathToFile)) AppendUser(User.CreateEmpty("ADMIN"));
        }

        private void AppendUser(User user)
        {
            using (var sw = GetStreamWriter(_pathToFile))
            {
                var json = user.ToJson();
                sw.WriteLine(json);
            }
        }

        public bool HasUser(string userName)
        {
            using (var sr = GetStreamReader(_pathToFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var user = User.FromJson(line);
                    if (user.Name == userName) return true;
                }
            }

            return false;
        }

        public void Create(User user)
        {
            if (HasUser(user.Name))
            {
                MessageBox.Show("Пользователь с именем \"" + user.Name + "\"  уже существует.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else AppendUser(user);
        }

        public User GetUser(string userName)
        {
            using (var sr = GetStreamReader(_pathToFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var user = User.FromJson(line);
                    if (user.Name == userName) return user;
                }
            }
            MessageBox.Show("Пользователя с именем \"" + userName + "\"  не существует.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public bool Auth(string userName, string password)
        {
            var user = GetUser(userName);
            return user != null && PasswordManager.ComparePasswords(user.Password, password);
        }

        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            using (var sr = new StreamReader(_pathToFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var user = User.FromJson(line);
                    users.Add(user);
                }
            }

            return users;
        }

        public void Update(User newUser)
        {
            var tempFile = Path.GetTempFileName();
            using (var sr = GetStreamReader(_pathToFile))
            using (var sw = GetStreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var user = User.FromJson(line);
                    if (user.Name != newUser.Name)
                        sw.WriteLine(line);
                    else
                        sw.WriteLine(newUser.ToJson());
                }
            }

            File.Delete(_pathToFile);
            File.Move(tempFile, _pathToFile);
        }

        public void Delete(string userName)
        {
            var tempFile = Path.GetTempFileName();
            using (var sr = GetStreamReader(_pathToFile))
            using (var sw = GetStreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var user = User.FromJson(line);
                    if (user.Name != userName) sw.WriteLine(line);
                }
            }

            File.Delete(_pathToFile);
            File.Move(tempFile, _pathToFile);
        }

        private static StreamWriter GetStreamWriter(string path)
        {
            return File.Exists(path) ? File.AppendText(path) : File.CreateText(path);
        }

        private StreamReader GetStreamReader(string path)
        {
            return File.OpenText(path);
        }
    }
}