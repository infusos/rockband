using UnityEngine;
using System.Collections;

public class EventsManager : MonoBehaviour{

	public delegate void DataManagerListener();
	public event DataManagerListener OnDataManagerListener;

	public delegate void UserDataListener (int status, object game);
	public event UserDataListener OnUserDataListener;

	public delegate void InitializeGameListener (Game game);
	public event InitializeGameListener OnInitializeGameListener;

	public delegate void InitializedGameListener();
	public event InitializedGameListener OnInitializedGameListener;

	public delegate void SceneChangedListener();
	public event SceneChangedListener OnSceneChangedListener;

	public void OnDataManager(){
		if (OnDataManagerListener != null) {
			OnDataManagerListener();
		}
	}

	public void OnUserData(int status, object game){
		if (OnUserDataListener != null) {
			OnUserDataListener(status,game);
		}
	}

	public void OnInitializeGame(Game game){
		if (OnInitializeGameListener != null) {
			OnInitializeGameListener(game);
		}
	}

	public void OnInitializedGame(){
		if (OnInitializedGameListener != null) {
			OnInitializedGameListener();
		}
	}

	public void OnSceneChanged(){
		if (OnSceneChangedListener != null) {
			OnSceneChangedListener();
		}
	}
}
