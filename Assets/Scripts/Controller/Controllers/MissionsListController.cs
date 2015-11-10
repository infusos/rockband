using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class MissionsListController : BaseController {

	public GameObject MissionsGroup;
	public List<GameObject> MissionButtons;

	private bool mVisible = false;

	void Start () {
	
	}

	void Update () {
	
	}

	public void Toggle(){

		Sequence toogleSeq = DOTween.Sequence ();

		if (mVisible) {
			toogleSeq.Append(MissionsGroup.transform.DOScaleY(1,0.15f));
			foreach (GameObject mission in MissionButtons) {
				toogleSeq.Append(mission.transform.DOScale (1, 0.05f));
			}
		} else {
			toogleSeq.Append(MissionsGroup.transform.DOScaleY(0,0.15f));
			foreach (GameObject mission in MissionButtons) {
				toogleSeq.Append(mission.transform.DOScale (0, 0.05f));
			}
		}

		mVisible = !mVisible;
	}

}
