using UnityEngine;
using System.Collections;

public class Startmanager: MonoBehaviour {

	public GameObject waitingtext;
	public GameObject starttext;
	public GameObject outbutton;
	private GameObject waitingtext_obj;
	private GameObject starttext_obj;
	private GameObject button_obj;
	private string[] gamestate = new string[1];

	// Use this for initialization
	void Start () {
		waitingtext_obj = (GameObject)Instantiate (waitingtext);
		waitingtext_obj.transform.SetParent(this.transform.parent);
		waitingtext_obj.transform.localPosition = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		gamestate = GlobalObject.getstate();
		if (gamestate[0] == "playing") {
			Destroy(waitingtext_obj.gameObject);
			starttext_obj = (GameObject)Instantiate (starttext);
			starttext_obj.transform.SetParent(this.transform.parent);
			starttext_obj.transform.localPosition = new Vector3(0, 0, 0);
			StartCoroutine(delaydestroy(1f, starttext_obj));
			button_obj = (GameObject)Instantiate(outbutton);
			button_obj.transform.SetParent(this.transform.parent);
			button_obj.transform.localPosition = this.transform.localPosition;
			StartCoroutine(delaydestroy(1f, this.gameObject));
		}
	}

	IEnumerator delaydestroy(float time, GameObject obj) {
		yield return new WaitForSeconds(time);
		Destroy (obj.gameObject);
	}
}
