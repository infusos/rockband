using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

public class BaseApplication : MonoBehaviour {

	public static EventsManager EventsManagerInstance;
	public static SceneManager SceneManagerInstance;
	public static DataManager DataManagerInstance;
	public static GameManager GameManagerInstance;

	void Start () {

		GameObject.DontDestroyOnLoad (this);

		EventsManagerInstance = this.GetComponent<EventsManager> ();

		BaseApplication.EventsManagerInstance.OnUserDataListener += onUserData;
		BaseApplication.EventsManagerInstance.OnDataManagerListener += onDataManagerLoaded;
		BaseApplication.EventsManagerInstance.OnInitializedGameListener += onInitializedGame;

		DataManagerInstance = this.gameObject.AddComponent<DataManager> ();
		SceneManagerInstance  = this.gameObject.AddComponent<SceneManager> ();
		GameManagerInstance   = this.gameObject.AddComponent<GameManager> ();

		initManagers ();

	}

	void Update () {

	}

	private void initManagers(){
		DataManagerInstance.InitializeManager ();
	}

	private void onDataManagerLoaded(){
		Debug.Log ("Assets loaded.");
		DataManagerInstance.LoadUserData ("user.dat");
	}

	private void onUserData(int status, object game){
		if (status == Constants.ON_USERDATA_NOT_INITIALIZED) {
			Debug.LogWarning ("User data not initialized yet.");
			DataManagerInstance.CreateUserData ();
		} else if (status == Constants.ON_USERDATA_UNSAVED) {
			Debug.LogError ("User data not saved.");
		} else if (status == Constants.ON_USERDATA_LOADED) {
			Debug.Log ("User data loaded.");
			GameManagerInstance.game = (Game)game;
			SceneManagerInstance.ChangeScene (Constants.TITLE_SCENE);
		} else if (status == Constants.ON_USERDATA_SAVED) {
			Debug.Log ("User data saved.");
		} else if (status == Constants.ON_USERDATA_INITIALIZED) {
			Debug.Log("User data initialized.");
			GameManagerInstance.game = (Game)game;
			SceneManagerInstance.ChangeScene (Constants.TITLE_SCENE);
		}
	}

	private void onInitializedGame(){
		Debug.Log ("Initialized game.");
		DataManagerInstance.SaveUserData (GameManagerInstance.game, "user.dat", true);
	}
}
