using System;
using System.Collections.Generic;
using System.Security.RightsManagement;
using System.Text;
using System.Text.Json;

namespace МенеджнрПаролей
{
    public static class UserStorage
    {
        private static readonly string filepath = "users.json";

        public static List<User> LoadUsers()
        {
            if (!File.Exists(filepath))
                return new List<User>();
            
            string json = File.ReadAllText(filepath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<User>();

            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        public static void SaveUsers(List<User> users)
        {
            var options = new JsonSerializerOptions {  WriteIndented = true };
            string json = JsonSerializer.Serialize(users, options);
            File.WriteAllText(filepath, json);
        }
    }
}