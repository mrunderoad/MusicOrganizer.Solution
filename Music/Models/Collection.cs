using System.Collections.Generic;

namespace Music.Models
{
  public class Collection
  {
    private static List<Collection> _records = new List<Collection> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Artist> Artists { get; set; }

    public Collection(string recordName)
    {
      Name = recordName;
      _records.Add(this);
      Id = _records.Count;
      Artists = new List<Artist>{};
    }

    public static void ClearAll()
    {
      _records.Clear();
    }

    public static List<Collection> GetAll()
    {
      return _records;
    }

    public static Collection Find(int searchId)
    {
      return _records[searchId-1];
    }

    public void AddArtist(Artist artist)
    {
      Artists.Add(artist);
    }
  }
}