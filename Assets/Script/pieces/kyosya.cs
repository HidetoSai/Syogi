using UnityEngine;
using System.Collections;

public class Kyosya : CreatePanel {

	Vector3 onestep;
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
		GlobalObject.setobject (this.gameObject);
		onestep = this.transform.position;
		onestep = new Vector3 (this.transform.position.x, this.transform.position.y + 50f, 0);
		RaycastHit2D hit = Physics2D.Raycast(onestep,  Vector2.up);
		if (hit.collider != null) {
			maxmove = changetable.changeposition (hit.collider.gameObject.transform.localPosition.y) - 2f;
		} else {
			nowpos = changetable.changeposition (this.transform.localPosition.y);
			maxmove = nowpos - 1f;
		}
		createpanel ((int)maxmove, 6);
	}
}
