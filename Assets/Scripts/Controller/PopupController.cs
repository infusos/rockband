using UnityEngine;
using System.Collections;

public class PopupController : BaseController {

	public void OnClose(int itemId){
		mEventsManager.OnItemClick (itemId);
	}

}
