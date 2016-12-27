using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{

    public class QualityRepository
    {
        public fauxrealEntities _db = new fauxrealEntities();
        
        public QualityRepository()
        { }
        public List<Quality> Find(string searchString)
        {
            var qualities1 = _db.Qualities.ToList();
            var qualities = qualities1
                .Select(q => new Quality(q.QualitiesID, q.Quality1))
                .Where(q => q.Quality1.StartsWith(searchString))
                .ToList();

            return
                 string.IsNullOrWhiteSpace(searchString) || searchString.Length < 1
                    ? new List<Quality>()
                    : qualities;
        }
    }
}