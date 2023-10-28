﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.API.Dtos
{
    public class TourReviewDto
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        //public Tourist Tourist { get; set; }
        //public Tour Tour {  get; set; } 
        public DateTime VisitDate { get; set; }
        public DateTime RatingDate { get; set; }
        public string ImageLinks { get; set; }
    }
}