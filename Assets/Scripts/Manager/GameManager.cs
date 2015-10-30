using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Game game { get; set; }

	void Start () {

	}
	
	void Update () {

	}

	void OnLevelWasLoaded(int level) {
		if (level == Constants.LEVEL_LOCATION) {
			SetLocationBackground();
		}
	}

	public void SetGame(Game game){
		this.game = game;
		BaseApplication.EventsManagerInstance.OnInitializedGame ();
	}

	public void SetLocationBackground(){
		print (game.user.money);
	}

}
