using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Views_Stylist_Show
  {
    private static List<Stylist> _instances = new List<Stylist> {};
    public string Name { get; set; }
    public string Description {get; set;}
    public int Id { get; }

    public List<Client> Clients { get; set; }

    public Stylist(string stylistName, string stylistDescription)
    {
      Name = stylistName;
      Description = stylistDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Clients = new List<Client>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Stylist> GetAll()
    {
      return _instances;
    }

    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddClient(Client client)
    {
      Clients.Add(client);
    }

  }
}