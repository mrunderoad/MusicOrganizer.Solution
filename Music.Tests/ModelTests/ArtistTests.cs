using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Music.Models;
using System;

namespace Music.TestTools
{
  [TestClass]
  public class ArtistTests // : IDisposable
  {

    // public void Dispose()
    // {
    //   Artist.ClearAll();
    // }

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
  }
}