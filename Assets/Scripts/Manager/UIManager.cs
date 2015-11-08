using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	private GameManager mGameManager = BaseApplication.GameManagerInstance;
	private EventsManager mEventsManager = BaseApplication.EventsManagerInstance;

	public Text LocationText;

	void Start () {
		mEventsManager.OnItemClickListener += onItemClick;
		mEventsManager.OnLocationChangedListener += onLocationChanged;
	}

	void Update () {
	
	}

	private void onItemClick(int itemId){
		Debug.Log ("Item with id: "+itemId+ " clicked");
	}

	private void onLocationChanged(){
		LocationText.text = mGameManager.game.currentLocation.name;
	}
}
