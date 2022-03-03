using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Music.Models;

namespace Music.Controllers
{
  public class CollectionsController : Controller
  {
    [HttpGet("/collections")]
    public ActionResult Index()
    {
      List<Collection> allCollections = Collection.GetAll();
      return View(allCollections);
    }

    [HttpGet("/collections/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/collections")]
    public ActionResult Create(string recordName)
    {
      Collection newCollection = new Collection(recordName);
      return RedirectToAction("Index");
    }

    [HttpGet("/collections/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Collection selectedCollection = Collection.Find(id);
      List<Artist> collectionArtists = selectedCollection.Artists;
      model.Add("collection", selectedCollection);
      model.Add("artists", collectionArtists);
      return View(model);
    }

    [HttpPost("/collections/{collectionId}/artists")]
    public ActionResult Create(int collectionId, string artistName)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Collection foundCollection = Collection.Find(collectionId);
      Artist newArtist = new Artist(artistName);
      foundCollection.AddArtist(newArtist);
      List<Artist> collectionArtists = foundCollection.Artists;
      model.Add("artists", collectionArtists);
      model.Add("collection", foundCollection);
      return View("Show", model);
    }
  }
}