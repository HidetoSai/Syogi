using UnityEngine;
using System.Collections;

public class piecespread : MonoBehaviour {

	float temp;
	// Use this for initialization
	void Start () {
		for(int i = 1; i <= 9; i++) {
			temp = changetable.changeposition((float)i);
			GameObject pref_fu = (GameObject)Resources.Load ("Prefabs/Pieces/Fu");
			Instantiate(pref_fu, new Vector2(temp, -70f), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
