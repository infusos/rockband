using UnityEngine;
using System.Collections;

[System.Serializable]
public class Actor {

	public int id { get; set; }
	public string name { get; set; }
	public bool isAvailable { get; set; }
	public long restTime { get; set; }

	public Actor(){

	}

}
