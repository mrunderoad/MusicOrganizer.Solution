using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music.Models;
using System.Collections.Generic;
using System;

namespace Music.Tests
{
  [TestClass]
  public class CollectionTests : IDisposable
  {
    
    public void Dispose()
    {
      Collection.ClearAll();
    }

    [TestMethod]
    public void CollectionConstructor_CreatesInstanceOfCollection_Collection()
    {
      Collection newCollection = new Collection("Rock and Roll!");
      Assert.AreEqual(typeof(Collection), newCollection.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsCollectionName_String()
    {
      string name = "The Twist";
      Collection newCollection = new Collection(name);
      string result = newCollection.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCollectionId_Int()
    {
      string name = "The Fall";
      Collection newCollection = new Collection(name);
      int result = newCollection.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCollectionObjects_CollectionList()
    {
      string name1 = "The Twist";
      string name2 = "The Fall";
      Collection newCollection1 = new Collection(name1);
      Collection newCollection2 = new Collection(name2);
      List<Collection> newList = new List<Collection> { newCollection1, newCollection2 };
      List<Collection> result = Collection.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCollection_Collection()
    {
      string name1 = "The Twist";
      string name2 = "The Fall";
      Collection newCollection1 = new Collection(name1);
      Collection newCollection2 = new Collection(name2);
      Collection result = Collection.Find(2);
      Assert.AreEqual(newCollection2, result);
    }
  }
}