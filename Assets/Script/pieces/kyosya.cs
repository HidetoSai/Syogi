using UnityEngine;
using System.Collections;

public class Kyosya : MoveBehavior {

	private float nowpos = 0;
	private float maxmove = 0;
	private Collider2D raycrash;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClick() {
		if (GlobalObject.overlap_flag == 0) {
			Kyosya_move();
			GlobalObject.overlap_flag++;
		} else {
			var clones = GameObject.FindGameObjectsWithTag ("panel");
			foreach (var clone in clones) {
				Destroy (clone);
			}
			GlobalObject.overlap_flag = 0;
		}
	}
	
	void Kyosya_move() {
		GlobalObject.setobject (this.gameObject);
		raycrash = rayshot (6);
		Debug.Log (raycrash);
		if (raycrash != null) {
			maxmove = changetable.changeposition (raycrash.gameObject.transform.localPosition.y) - 2f;
		} else {
			nowpos = changetable.changeposition (this.transform.localPosition.y);
			maxmove = nowpos - 1f;
		}
		createpanel ((int)maxmove, 6);
	}
}
