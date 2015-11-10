using UnityEngine;
using System.Collections;
using DG.Tweening;

public class PopupController : BaseController {

	private CanvasGroup mCanvasGrp;

	public void Show(bool show){
		mCanvasGrp = this.gameObject.GetComponent<CanvasGroup> ();
		if (show) {
			mCanvasGrp.DOFade(1,0.15f);
			mCanvasGrp.transform.DOScale(1,0.15f);
		} else {
			mCanvasGrp.DOFade(0,0.15f);
			mCanvasGrp.transform.DOScale(0,0.15f);
		}
	}
}
