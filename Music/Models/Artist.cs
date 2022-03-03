using System.Collections.Generic;

namespace Music.Models
{
  public class Artist
  {
    public string Name { get; set; }
    public int Id { get; }
    private static List<Artist> _artists = new List<Artist> {};

    public Artist(string name)
    {
      Name = name;
      _artists.Add(this);
      Id = _artists.Count;
    }

    public static List<Artist> GetAll()
    {
      return _artists;
    }

    public static void ClearAll()
    {
      _artists.Clear();
    }
  }
}