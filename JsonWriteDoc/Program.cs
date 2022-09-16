
using JsonWriteDoc;
using System.Text.Json;

List<User> users = new List<User>();

users = Sauvegarde.LoadData();

Console.WriteLine(users[2].Name);


