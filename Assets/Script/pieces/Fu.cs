using UnityEngine;
using System.Collections;

public class Fu : CreatePanel {

	private float nowpos = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClick() {
		if (GlobalObject.overlap_flag == 0) {
			Fu_move ();
			GlobalObject.overlap_flag++;
		} else {
			var clones = GameObject.FindGameObjectsWithTag ("panel");
			foreach (var clone in clones) {
				Destroy (clone);
			};
			GlobalObject.overlap_flag = 0;
		}
	}
	
	public void Fu_move() {
		GlobalObject.setobject (this.gameObject);
		nowpos = changetable.changeposition (this.transform.localPosition.y);
		if (nowpos != 1) {
			createpanel (1, 6);
		}
	}
}