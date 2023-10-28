﻿using Explorer.BuildingBlocks.Core.Domain;
using Explorer.Tours.Core.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.Core.Domain
{
    public class Tour : Entity
    {
        public int UserId { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public double Price { get; init; }
        public TourDifficulty? Difficulty { get; init; }    
        public TransportType? TransportType { get; init; }
        public TourStatus? Status { get; init; }
        public List<String> Tags { get; init; }
        public ICollection<TourEquipment> TourEquipments { get; set; }

        public Tour()
        {
            Tags = new List<String>();
        }

        public Tour(int userId, string name, string description, double price, TourDifficulty? difficulty, TransportType? transportType, TourStatus? status, List<string> tags)
        {
            UserId = userId;
            Name = name;
            Description = description;
            Price = price;
            Difficulty = difficulty;
            TransportType = transportType;
            Status = status;
            Tags = tags;

            Validate();
        }

        private void Validate()
        {
            if (UserId <= 0) throw new ArgumentException("Invalid UserId");
            if (string.IsNullOrWhiteSpace(Description)) throw new ArgumentException("Invalid description.");
            if (Price < 0) throw new Exception("Invalid price.");
            if (string.IsNullOrEmpty(Name)) throw new ArgumentException("Invalid name");
        }
    }
}