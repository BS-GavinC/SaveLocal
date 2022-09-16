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

            string myUsers = JsonSerializer.Serialize(users);
            
            File.WriteAllText(Environment.CurrentDirectory + "/Saves.txt", myUsers);
          
        }

        public static List<User>  LoadData()
        {
            string mesusers;
            mesusers = File.ReadAllText(Environment.CurrentDirectory + "/Saves.txt");
            return JsonSerializer.Deserialize<List<User>>(mesusers);
        }
    }
}
