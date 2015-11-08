using UnityEngine;
using System.Collections;

public class EventsManager : MonoBehaviour{

	/***************/
	/* CORE EVENTS */
	/***************/

	public delegate void DataManagerListener();
	public event DataManagerListener OnDataManagerListener;

	public delegate void UserDataListener (int status, object game);
	public event UserDataListener OnUserDataListener;

	/***************/
	/* GAME EVENTS */
	/***************/

	public delegate void InitializeGameListener (Game game);
	public event InitializeGameListener OnInitializeGameListener;

	public delegate void InitializedGameListener();
	public event InitializedGameListener OnInitializedGameListener;

	public delegate void SceneChangedListener();
	public event SceneChangedListener OnSceneChangedListener;

	public delegate void ChangeBackgroundListener ();
	public event ChangeBackgroundListener OnChangeBackgroundListener;

	public delegate void LocationChangedListener ();
	public event LocationChangedListener OnLocationChangedListener;

	/*************/
	/* UI EVENTS */
	/*************/

	public delegate void ItemClickedListener(int itemId);
	public event ItemClickedListener OnItemClickListener;

	public void OnLocationChanged(){
		if (OnLocationChangedListener != null) {
			OnLocationChangedListener();
		}
	}
	
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

	public void OnChangeBackground(){
		if (OnChangeBackgroundListener != null) {
			OnChangeBackgroundListener ();
		}
	}

	public void OnItemClick(int itemId){
		if (OnItemClickListener != null) {
			OnItemClickListener(itemId);
		}
	}
}
