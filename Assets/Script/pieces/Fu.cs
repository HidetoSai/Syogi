using UnityEngine;
using System.Collections;

public class Fu : MonoBehaviour {

	public GameObject panel;
	GameObject panel_obj;
	private float offset = 50f;
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
		nowpos = changetable.changeposition(this.transform.localPosition.y);
		if (nowpos != 1) {
			panel_obj = (GameObject)Instantiate(panel);
			panel_obj.transform.SetParent(this.transform.parent);
			panel_obj.transform.localPosition = this.transform.localPosition;
			panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x, panel_obj.transform.localPosition.y + offset, 0f);
		}
		GlobalObject.setobject (this.gameObject);
	}
}
