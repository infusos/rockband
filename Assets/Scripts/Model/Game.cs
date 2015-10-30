using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Game {

	public User user { get; set; }
	public List<NPC> npcs { get; set; }
	public List<Location> locations { get; set; }
	public Location currentLocation { get; set; }

	public Game(){

	}

}
