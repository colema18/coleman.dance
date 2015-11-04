using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coleman.Dance.Models
{
    public class Performance
    {
        [ScaffoldColumn(false)]
        [BsonId]
        public ObjectId PerformanceId { get; set; }

        [Required]
        public string Title { get; set; }

        [UIHint("WYSIWYG")]
        public string Details { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public DateTime EndDate { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }

    }
}
