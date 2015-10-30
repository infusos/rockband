using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;	
using System;
using System.Runtime.Serialization.Formatters.Binary;
using SimpleJSON;

public class DataManager : MonoBehaviour {

	void Start () {

	}

	void Update () {

	}

	public void InitializeManager(){
		StartCoroutine ("iLoadAssets");
	}

	public bool SaveUserData(object obj, string filename, bool firstTime){
		try{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Create(Application.persistentDataPath+"/"+filename);
			bf.Serialize (file, obj);
			file.Close ();
			if(!firstTime){
				BaseApplication.EventsManagerInstance.OnUserData(Constants.ON_USERDATA_SAVED, null);
			}else{
				BaseApplication.EventsManagerInstance.OnUserData(Constants.ON_USERDATA_INITIALIZED, obj);
			}
		}catch(IOException e){
			BaseApplication.EventsManagerInstance.OnUserData(Constants.ON_USERDATA_UNSAVED, null);
			return false;
		}
		return true;
	}

	public object LoadUserData(string filename){
		object obj;
		try{
			FileStream file = File.OpenRead(Application.persistentDataPath+"/"+filename);
			BinaryFormatter bf = new BinaryFormatter();
			obj = bf.Deserialize(file);
			file.Close();
			BaseApplication.EventsManagerInstance.OnUserData(Constants.ON_USERDATA_LOADED, obj);
		}catch(IOException e){
			BaseApplication.EventsManagerInstance.OnUserData(Constants.ON_USERDATA_NOT_INITIALIZED, null);
			return null;
		}
		return obj;
	}

	public void CreateUserData(){
		User user = loadUserTemplate ();
		Game game = loadGameTemplate ();
		game.user = user;
		SaveUserData (game, "user.dat", true);
	}

	private Game loadGameTemplate(){
		Debug.Log ("Creating game ...");
		Game game = new Game ();
		game.npcs = loadNPC ();
		game.locations = loadLocations ();
		game.currentLocation = game.locations [0];
		Debug.Log ("Default location selected: " + game.currentLocation.name);
		return game;
	}

	private User loadUserTemplate(){
		Debug.Log ("Creating user ...");
		User user = new User ();
		user.id = 0;
		user.isAvailable = true;
		user.money = 10;
		user.tokens = 10;
		user.name = "Unnamed";
		user.tokens = 10;
		user.energy = 10;
		user.restTime = 0L;
		return user;
	}

	private List<NPC> loadNPC(){
		Debug.Log ("Creating npcs ...");
		List<NPC> npcs = new List<NPC> ();
		return npcs;
	}

	private List<Location> loadLocations(){
		Debug.Log ("Loading locations...");
		List<Location> locations = new List<Location> ();
		JSONNode N =  JSON.Parse(((TextAsset)Resources.Load (Constants.LOCATIONS, typeof(TextAsset))).text);

		for (int i = 0; i<N ["locations"].Count; i++) {
			Location location = new Location();
			location.id 	= N["locations"][i]["id"].AsInt;
			location.city 	= N["locations"][i]["city"];
			location.name 	= N["locations"][i]["name"];
			locations.Add(location);
		}
		return locations;
	}

	IEnumerator iLoadAssets(){
		yield return new WaitForSeconds(4);
		BaseApplication.EventsManagerInstance.OnDataManager ();
	}
}
