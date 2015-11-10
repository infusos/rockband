using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	private GameManager mGameManager = BaseApplication.GameManagerInstance;
	private EventsManager mEventsManager = BaseApplication.EventsManagerInstance;
	public GameObject NavigationBar;
	public GameObject OptionsPopup;
	public GameObject MissionsList;

	public Text LocationText;

	void Start () {
		mEventsManager.OnLocationChangedListener += onLocationChanged;
	}

	void Update () {
	
	}

	public void OnClick(int id){
		if (id == Constants.BTN_OPTIONS) {
			OptionsPopup.GetComponent<PopupController>().Show(true);
		}
		if (id == Constants.BTN_CLOSE_OPTIONS_POPUP) {
			OptionsPopup.GetComponent<PopupController>().Show(false);
		}
		if (id == Constants.BTN_MISSIONS_LIST) {
			MissionsList.GetComponent<MissionsListController>().Toggle();
		}
	}

	private void onLocationChanged(){
		LocationText.text = mGameManager.game.currentLocation.name;
	}
}
