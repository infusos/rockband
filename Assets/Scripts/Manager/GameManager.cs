using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Game game { get; set; }

	private BackgroundController mBackgroundController;
	private EventsManager mEventsManager = BaseApplication.EventsManagerInstance;

	void Start () {
		mEventsManager.OnLocationChangedListener += setLocation;
	}
	
	void Update () {

	}

	void OnLevelWasLoaded(int level) {
		if (level == Constants.LEVEL_LOCATION) {
			mBackgroundController = GameObject.Find("cnvBackground").GetComponent<BackgroundController>();
			setLocation();
		}
	}

	public void SetGame(Game game){
		this.game = game;
		mEventsManager.OnInitializedGame ();
	}

	private void setLocation(){
		setBackground ();
	}

	private void setBackground(){
		mBackgroundController.ChangeBackground (game.currentLocation.id);
	}

}
