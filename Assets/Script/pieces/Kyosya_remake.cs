using UnityEngine;
using System.Collections;

public class Kyosya_remake : MonoBehaviour {

	public GameObject panel;
	GameObject panel_obj;
	private float offset = 35f;
	private float nowpos = 0;
	private float maxmove = 0;

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
		nowpos = changetable.changeposition(this.transform.localPosition.y);
		maxmove = nowpos - 1f;
		if (maxmove > 0) {
			for (int i = 0; i < maxmove; i++) {
				panel_obj = (GameObject)Instantiate (panel);
				panel_obj.transform.SetParent (this.transform.parent);
				panel_obj.transform.localPosition = this.transform.localPosition;
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x, panel_obj.transform.localPosition.y + offset, 0f);
				offset += 35f;
			}
			offset = 35f;
		}
		GlobalObject.setobject (this.gameObject);
	}

}
