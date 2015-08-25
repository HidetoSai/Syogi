using UnityEngine;
using System.Collections;

public class turnmanager : MonoBehaviour {

	public GameObject en_turntext;
	private GameObject en_turn_obj = null;
	private string[] turnplayer = new string[4];
	private string uid;
	private int count = 2;

	// Use this for initialization
	void Start () {
		uid = GlobalObject.getuserid ();
		StartCoroutine (delayturnchange (0.3f));
	}
	
	// Update is called once per frame
	void Update () {
		turnplayer = GlobalObject.getplay ();
		if(int.Parse(turnplayer[0]) == count){
			StartCoroutine (delayturnchange (0.3f));
			count++;
		}
	}

	void createtext() { 
		en_turn_obj = (GameObject)Instantiate (en_turntext);
		en_turn_obj.transform.SetParent(GameObject.Find("Canvas/Background/Board").transform.parent);
		en_turn_obj.transform.localPosition = new Vector3 (0f, 0f, 0f);
	}

	IEnumerator delayturnchange(float time) {
		yield return new WaitForSeconds (time);
		turnplayer = GlobalObject.getplay();
		if(en_turn_obj != null) {
			Destroy(en_turn_obj.gameObject);
		}
		if (turnplayer [2] != uid) {
			createtext();
		}
	}
}