using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	Vector3 TapPoint;
	new Collider2D collider;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			TapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			collider = Physics2D.OverlapPoint (TapPoint);
			if (collider){
				GameObject panel = collider.transform.gameObject;
				if(panel == this.gameObject) {
					GameObject tapped = GlobalObject.getobject();
					tapped.transform.localPosition = panel.transform.localPosition;
					var clones = GameObject.FindGameObjectsWithTag ("panel");
					foreach (var clone in clones){
						Destroy(clone);
					}
					GlobalObject.overlap_flag = 0;
				}
			}
		}
	}
}