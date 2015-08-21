using UnityEngine;
using System.Collections;

public class changetable : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public static float changeposition(float position) {
		float temp;
		float changed;

		if (position <= 9 && position >= 1) {
			temp = position - 5f;
			changed = temp * -50f;
			return changed; 
		} else {
			temp = position / -50f;
			changed = temp + 5f;
			return changed;
		}
	}

	public static float BoardToWorld(int board_p) {
		float changed;
		changed = board_p * 50f;
		return changed;
	}
}			