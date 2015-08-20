﻿using UnityEngine;
using System.Collections;

public class kyosya : MonoBehaviour {
	
	public GameObject panel;
	GameObject tappiece;
	GameObject secondtap;
	GameObject panel_obj;
	Vector3 TapPoint;
	private float offset = 35f;
	private float nowpos = 0;
	private float maxmove = 0;
	new Collider2D collider;
	private int flag = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	/*void Update () {
		if (flag == 0) {
			if (Input.GetMouseButtonDown (0)) {
				TapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				collider = Physics2D.OverlapPoint (TapPoint);
				if (collider) {
					tappiece = collider.transform.gameObject;
					Kyosya_move ();
					GlobalObject.setobject (tappiece);
					flag++;
				}
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				TapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				collider = Physics2D.OverlapPoint (TapPoint);
				if (collider) {
					GameObject secondtap = collider.transform.gameObject;
					if (secondtap.name == tappiece.name) {
						DestroyObject (panel_obj.gameObject);
						flag = 0;
					}
				}
			}
		}
	}*/

	public void OnClick() {
		if (GlobalObject.overlap_flag == 0) {
			if (flag == 0) {
				GlobalObject.overlap_flag++;
				TapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				collider = Physics2D.OverlapPoint (TapPoint);
				if (collider != null) {
					tappiece = collider.transform.gameObject;
					Kyosya_move();
					GlobalObject.setobject (tappiece);
					flag++;
				}
			} else {
				DestroyObject (panel_obj.gameObject);
				flag = 0;
				GlobalObject.overlap_flag = 0;
			}
		}
	}

	void Kyosya_move() {
		nowpos = changetable.changeposition(tappiece.transform.localPosition.y);
		maxmove = nowpos - 1f;
		if (maxmove > 0) {
			for (int i = 0; i < maxmove; i++) {
				panel_obj = (GameObject)Instantiate (panel);
				panel_obj.transform.SetParent (this.transform.parent);
				panel_obj.transform.localPosition = tappiece.transform.localPosition;
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x, panel_obj.transform.localPosition.y + offset, 0f);
				offset += 35f;
			}
			offset = 35f;
		}
	}
}
/*TapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
collider = Physics2D.OverlapPoint (TapPoint);
if (collider) {
	secondtap = collider.transform.gameObject;
	if (secondtap.name == tappiece.name) {
		DestroyObject (panel_obj.gameObject);
		GlobalObject.flag = 0;
	}
}*/