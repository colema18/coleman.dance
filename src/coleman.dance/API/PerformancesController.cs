using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Coleman.Dance.Models;
using MongoDB.Driver;
using MongoDB.Bson;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Coleman.Dance.API
{
    [Route("api/[controller]")]
    public class PerformancesController : Controller
    {

        [HttpGet]
        public IEnumerable<Performance> Get()
        {
            var performances = new List<Performance>();
            performances.Add(
                new Performance
                {
                    Title = "Test Title",
                    Link = "http://www.yahoo.com",
                    Image = "",
                    Details = "Test Details",
                    Date = DateTime.Now.AddDays(7),
                    EndDate = DateTime.Now.AddDays(8)
                });
            performances.Add(
                new Performance
                {
                    Title = "Test Title 2",
                    Link = "http://www.yahoo.com",
                    Image = "",
                    Details = "Test Details",
                    Date = DateTime.Now.AddDays(7),
                    EndDate = DateTime.Now.AddDays(8)
                });
            return performances;
        }

        // GET: api/values
        //[HttpGet]
        //public async Task<List<Performance>> Get()
        //{
        //    var client = new MongoClient("mongodb://localhost:27017");
        //    var database = client.GetDatabase("coleman-dance");
        //    var collection = database.GetCollection<Performance>("performances");

        //    var filter = new BsonDocument();

        //    var performances = await collection.Find(filter).ToListAsync();

        //    if (!performances.Any<Performance>())
        //    {
        //        var p = new Performance();
        //        p.Title = "Test Title";
        //        p.Link = "http://www.yahoo.com";
        //        p.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYoIVQfvLcGOr1hlFQbNrbdAyHcd81sxKNCUftD7a4BKiTJ9aikvKXmeo";
        //        p.Details = "Test Details";
        //        p.Date = DateTime.Now.AddDays(7);
        //        p.EndDate = DateTime.Now.AddDays(8);

        //        await collection.InsertOneAsync(p);
        //    }
        //    return performances;
        //}
    }
}
