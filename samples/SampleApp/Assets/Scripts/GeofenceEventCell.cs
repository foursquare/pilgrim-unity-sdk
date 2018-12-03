﻿using Foursquare;
using UnityEngine;
using UnityEngine.UI;

public class GeofenceEventCell : MonoBehaviour 
{

	public Text geofenceEventInfoText;

	public GeofenceEvent GeofenceEvent
	{
		set
		{	
			var text = "";
			if (value.Venue == null) {
				text += "No Venue Information\n\n\n";
			} else {
				Venue venue = value.Venue;
				text += venue.Name + "\n";
				text += venue.Location.Address + "\n";
				text += venue.Location.City + ", " + venue.Location.State + " " + venue.Location.PostalCode + "\n\n";
				text += "lat: " + string.Format("{0:0.000000}", value.Location.Latitude) + ", lng: " + string.Format("{0:0.000000}", value.Location.Longitude) + "\n";
				text += value.Timestamp;
			}
			geofenceEventInfoText.text = text;
		}
	}

}
