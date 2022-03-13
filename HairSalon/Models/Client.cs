using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    private static List<Client> _instances = new List<Client> {};
    public string Name { get; set; }
    public int Id { get; }
    

    public Client(string clientName)
    {
      Name = clientName;
      _instances.Add(this);
      Id = _instances.Count;
    }

     public static List<Client> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Client Find(int clientId)
    {
      return _instances[clientId-1];
    }
  }
}