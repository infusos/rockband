using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Location{

	public int id { get; set; }
	public string name { get; set; }
	public string city { get; set; }

	public enum LocationType { CITY, PLACE };

	public Location(){

	}

}
