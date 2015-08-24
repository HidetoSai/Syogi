using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnClick() {
		GameObject tapped = GlobalObject.getobject ();
		tapped.transform.localPosition = this.transform.localPosition;
		var clones = GameObject.FindGameObjectsWithTag ("panel");
		foreach (var clone in clones) {
			Destroy (clone);
		}
		GlobalObject.overlap_flag = 0;
	}
}