using UnityEngine;
using System.Collections;

public class BaseApplication : MonoBehaviour {

	private EventsManager mEventsManager;

	void Start () {
		GameObject.DontDestroyOnLoad (this);
		mEventsManager = new EventsManager ();
	}

	void Update () {
	
	}

}
