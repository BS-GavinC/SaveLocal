using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonWriteDoc
{
    static class Sauvegarde
    {
        
        
        public static void SaveData(List<User> users)
        {
            var option = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string myUsers = JsonSerializer.Serialize(users, option);
            
            File.WriteAllText(Environment.CurrentDirectory + "/Saves.txt", myUsers);
          
        }

        public static List<User>  LoadData()
        {
            string mesusers;
            
            try
            {
                mesusers = File.ReadAllText(Environment.CurrentDirectory + "/Saves.txt");
                return JsonSerializer.Deserialize<List<User>>(mesusers);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                List<User> users = new List<User>();
                Sauvegarde.SaveData(users);
                return users;
            }
            
        }
    }
}
