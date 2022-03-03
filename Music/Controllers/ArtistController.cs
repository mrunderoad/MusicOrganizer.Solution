using Microsoft.AspNetCore.Mvc;
using Music.Models;
using System.Collections.Generic;

namespace Music.Controllers
{
  public class ArtistsController : Controller
  {

    [HttpGet("/collections/{collectionId}/artists/new")]
    public ActionResult New(int collectionId)
    {
      Collection collection = Collection.Find(collectionId);
      return View(collection);
    }

    [HttpPost("/artists/delete")]
    public ActionResult DeleteAll()
    {
      Artist.ClearAll();
      return View();
    }

    [HttpGet("/collections/{collectionId}/artists/{artistId}")]
    public ActionResult Show(int collectionId, int artistId)
    {
      Artist artist = Artist.Find(artistId);
      Collection collection = Collection.Find(collectionId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("artist", artist);
      model.Add("collection", collection);
      return View(model);
    }
  }
}