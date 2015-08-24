using UnityEngine;
using System.Collections;

public class Startmanager: MonoBehaviour {

	public GameObject waitingtext;
	public GameObject starttext;
	public GameObject spread;
	public GameObject changetable;
	private GameObject waitingtext_obj;
	private GameObject starttext_obj;
	private GameObject spread_obj;
	private GameObject change_obj;
	private string[] gamestate = new string[1];
	private int count = 0;

	// Use this for initialization
	void Start () {
		waitingtext_obj = (GameObject)Instantiate (waitingtext);
		waitingtext_obj.transform.SetParent(this.transform.parent);
		waitingtext_obj.transform.localPosition = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		gamestate = GlobalObject.getstate();
		if (gamestate[0] == "playing" && count == 0) {
			Destroy(waitingtext_obj.gameObject);
			starttext_obj = (GameObject)Instantiate (starttext);
			starttext_obj.transform.SetParent(this.transform.parent);
			starttext_obj.transform.localPosition = new Vector3(0, 0, 0);
			StartCoroutine(delaydestroy(0.5f, starttext_obj));
			StartCoroutine(delaydestroy(1.5f, this.gameObject));
			change_obj = (GameObject)Instantiate(changetable);
			spread_obj = (GameObject)Instantiate(spread);
			spread_obj.transform.SetParent(this.transform.parent);
			count++;
		}
	}

	IEnumerator delaydestroy(float time, GameObject obj) {
		yield return new WaitForSeconds(time);
		Destroy (obj.gameObject);
	}
}
