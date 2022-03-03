using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Music.Models;
using System;

namespace Music.TestTools
{
  [TestClass]
  public class ArtistTests : IDisposable
  {

    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("test");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsArtistName_String()
    {
      string name = "Freddie Mercury";
      Artist newArtist = new Artist(name);
      string result = newArtist.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Freddie Mercury";
      Artist newArtist = new Artist(name);
      string updatedArtist = "ACDC";
      newArtist.Name = updatedArtist;
      string result = newArtist.Name;
      Assert.AreEqual(updatedArtist, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ArtistList()
    {
      List<Artist> newList = new List<Artist> { };
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsArtists_ArtistList()
    {
      string artist1 = "Freddie Mercury";
      string artist2 = "ACDC";
      Artist newArtist1 = new Artist(artist1);
      Artist newArtist2 = new Artist(artist2);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      string artist = "Freddie Mercury";
      Artist newArtist = new Artist(artist);
      int result = newArtist.Id;
      Assert.AreEqual(1, result);
    }
  }
}