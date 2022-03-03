using System.Collections.Generic;

namespace Music.Models
{
  public class Artist
  {
    public string ArtistName { get; set; }
    public int Id { get; }
    private static List<Artist> _artists = new List<Artist> {};

    public Artist(string artistName)
    {
      ArtistName = artistName;
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

    public static Artist Find(int searchId)
    {
      return _artists[searchId-1];
    }
  }
}