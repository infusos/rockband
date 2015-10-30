using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class User : Actor{

	public int money { get; set; }
	public int energy { get; set; }
	public int tokens { get; set; }

	private List<Friend> friends;

	public User(){

	}

}
