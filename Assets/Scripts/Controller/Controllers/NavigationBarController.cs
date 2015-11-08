using UnityEngine;
using System.Collections;

public class NavigationBarController : BaseController {

	void Start () {
	
	}

	void Update () {
	
	}

	public void OnOptionsClick(){
		mEventsManager.OnItemClick (Constants.BTN_OPTIONS);
	}
}
