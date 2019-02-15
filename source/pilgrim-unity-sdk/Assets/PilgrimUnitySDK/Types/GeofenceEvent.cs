using System;
using System.Collections.Generic;
using UnityEngine;

namespace Foursquare
{

    [Serializable]
    public class GeofenceEvent
    {

#pragma warning disable 0649

        [SerializeField]
        private string _venueId;

        public string VenueId { get { return _venueId; } }

        [SerializeField]
        private string[] _categoryIds;

        public IList<string> CategoryIds { get { return new List<string>(_categoryIds); } }

        [SerializeField]
        private string[] _chainIds;

        public IList<string> ChainIds { get { return new List<string>(_chainIds); } }

        [SerializeField]
        private string _partnerVenueId;

        public string PartnerVenueId { get { return _partnerVenueId; } }

        [SerializeField]
        private Venue _venue;

        public Venue Venue { get { return _venue; } }

        [SerializeField]
        private Location _location;

        public Location Location { get { return _location; } }

        [SerializeField]
        private double _timestamp;

        public DateTime Timestamp { get { return _timestamp.DateTimeFromUnixTime(); } }

#pragma warning restore 0649

    }

}