﻿using UnityEngine;
using System.Collections;


public class OptionsPopupController : PopupController {

	void Start () {

	}

	void Update () {
	
	}

	public void ShowPopup(bool show){
		this.gameObject.SetActive (show);
	}
}
