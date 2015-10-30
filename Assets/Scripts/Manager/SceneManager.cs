using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	void Start () {

	}

	void Update () {

	}

	public void ChangeScene(string scene){
		Application.LoadLevel (scene);
		if (scene == Constants.TITLE_SCENE) {
			StartCoroutine("LoadCity");
		}
		return;
	}

	IEnumerator LoadCity(){
		yield return new WaitForSeconds(4);
		BaseApplication.SceneManagerInstance.ChangeScene (Constants.LOCATION_SCENE);
	}
}
