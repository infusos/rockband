using UnityEngine;
using System.Collections;

public class EventsManager{

	public delegate void LoadScene(string test);

	public event LoadScene OnLoadScene;

	public EventsManager(){

	}

}
