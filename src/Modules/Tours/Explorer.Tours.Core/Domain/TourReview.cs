﻿using Explorer.BuildingBlocks.Core.Domain;
using Explorer.Stakeholders.Infrastructure.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.Core.Domain
{
    public class TourReview : Entity
    {
        public int Rating { get; init; }
        public string Comment { get; init; }
        public long UserId { get; init; }
        public long TourId { get; init; }
        //public Tourist Tourist { get; init; }
        public Tour Tour {  get; init; } 
        public DateTime VisitDate { get; init; }
        public DateTime RatingDate { get; init; }
        public List<string>? ImageLinks { get; init; }

        public TourReview() 
        { 
        
        }

        public TourReview(int rating, string comment, DateTime visitDate, DateTime ratingDate, List<string> imageLinks, long userId, long tourId)
        {
            if (rating < 1 || rating > 5)
            {
                throw new ArgumentException("Rating must be between 1 and 5");
            }

            Rating = rating;
            Comment = comment;
            VisitDate = visitDate;
            RatingDate = ratingDate;
            ImageLinks = imageLinks;
            UserId = userId;
            TourId = tourId;
        }
    }
}
