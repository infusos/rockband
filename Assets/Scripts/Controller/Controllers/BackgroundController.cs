using UnityEngine;
using System.Collections;

public class BackgroundController : BaseController {

	void Start () {

	}

	void Update () {
	
	}

	public void ChangeBackground(int locationId){
		Debug.Log ("Location Changed so we've to change the background "+locationId);
	}
}
