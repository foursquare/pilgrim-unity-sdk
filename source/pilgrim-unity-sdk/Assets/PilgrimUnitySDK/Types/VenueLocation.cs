using System;
using UnityEngine;

namespace Foursquare
{

    [Serializable]
    public class VenueLocation
    {
        
        [SerializeField]
        private string address;

        public string Address { get { return address; } }

        [SerializeField]
        private string crossStreet;

        public string CrossStreet { get { return crossStreet; } }

        [SerializeField]
        private string city;

        public string City { get { return city; } }

        [SerializeField]
        private string state;

        public string State { get { return state; } }

        [SerializeField]
        private string postalCode;

        public string PostalCode { get { return postalCode; } }

        [SerializeField]
        private string country;

        public string Country { get { return country; } }

        [SerializeField]
        private Location coordinate;

        public Location Coordinate { get { return coordinate; } }

    }

}