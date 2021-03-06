﻿using System;

namespace TDDSample.Web.Models.Rentals
{
    public sealed class Movie
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public string Name { get; }
        public MovieRentalType RentalType { get; }

        public Movie(string name, MovieRentalType rentalType)
        {
            Name = name;
            RentalType = rentalType;
        }
    }
}