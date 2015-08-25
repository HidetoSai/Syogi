using UnityEngine;
using System.Collections;

public class changetable : MonoBehaviour {

	private static string[,] usersinfo = new string[2,2];
	private static string uid;
	private static float offset;
	
	// Use this for initialization
	void Start () {
		uid = GlobalObject.getuserid();
		StartCoroutine (firstdelay (0.1f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public static float changeposition(float position) {
		float temp;
		float changed;
		if (position <= 9 && position >= 1) {
			temp = position - 5f;
			changed = temp * offset;
			return changed; 
		} else {
			temp = position / offset;
			changed = temp + 5f;
			return changed;
		}
	}

	public static float distancesearch(float max, float nowpos) {
		float temp;
		float changed;
		temp = 
	}

	IEnumerator firstdelay(float time) {
		yield return new WaitForSeconds(time);
		usersinfo = GlobalObject.getusers ();
		if (usersinfo [0, 0] == uid) {
			offset = -50f;
		} else {
			offset = 50f;
		}
	}
}