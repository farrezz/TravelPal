﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TravelPal;

namespace TravelPal.Models
{
    internal class Travel
    {
        public string? Country { get; set; }
        public string? City{ get; set; }
        public int? Passangers { get; set; }


        //Constructior som "setter" resan.
        public Travel(string country, string city, int passangers)
        {
            Country = country;
            Passangers = passangers;
            City = city;
        }
/*
        public static List<Travel> PackingListItem{ get; set; } = new()
        {

        };

   */
        public virtual string GetIno()
        {

            //TODO:
            return $"Destination: {Country}, city:  {City}, Traveller(s): {Passangers}";
        }

    };
}
