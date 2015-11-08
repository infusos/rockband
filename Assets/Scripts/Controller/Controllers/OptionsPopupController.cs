using UnityEngine;
using System.Collections;

public class OptionsPopupController : PopupController {

	void Start () {
	
	}

	void Update () {
	
	}

	public void OnCloseClick(){
		OnClose (Constants.BTN_CLOSE_OPTIONS_POPUP);
	}
}
