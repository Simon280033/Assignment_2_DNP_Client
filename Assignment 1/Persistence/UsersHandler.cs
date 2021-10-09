using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace FileData
{
    public class UsersHandler
    {
        public IList<User> Users { get; private set; }
        
        private readonly string usersFile = "users.json";

        public UsersHandler()
        {
            Users = File.Exists(usersFile) ? ReadData<User>(usersFile) : new List<User>();
            Console.WriteLine("Count: " + Users.Count);
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(usersFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        private void SaveChanges()
        {
            // storing persons
            string jsonUsers = JsonSerializer.Serialize(Users, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(usersFile, false))
            {
                outputFile.Write(jsonUsers);
            }
        }

        public bool UserExists(string username)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].UserName.Equals(username))
                {
                    return true;
                }
            }
            return false;
        }

        public void WriteNewUser(User NewUser)
        {
            Users.Add(NewUser);

            SaveChanges();
        }
    }
}