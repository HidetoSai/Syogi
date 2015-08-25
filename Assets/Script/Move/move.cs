using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	private GameObject tapped;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnClick() {
		tapped = GlobalObject.getobject ();
		StartCoroutine (Post("http://192.168.3.83:3000/plays/update", (int)changetable.changeposition(this.transform.localPosition.x), (int)changetable.changeposition(this.transform.localPosition.y)));
		tapped.transform.localPosition = this.transform.localPosition;
		var clones = GameObject.FindGameObjectsWithTag ("panel");
		foreach (var clone in clones) {
			Destroy (clone);
		}
		GlobalObject.overlap_flag = 0;
	}

	IEnumerator Post(string url, int posx, int posy) {
		WWWForm form = new WWWForm();
		string playid = GlobalObject.getplayid ();
		string userid = GlobalObject.getuserid ();
		int moveid = int.Parse(tapped.transform.name);
		form.AddField ("play_id", playid);
		form.AddField ("user_id", userid);
		form.AddField ("move_id", moveid);
		form.AddField ("posx", posx);
		form.AddField ("posy", posy);
		form.AddField ("promote", "false");
		form.AddField ("get_id", "-1");
		WWW www = new WWW (url, form);
		yield return www;
		Debug.Log(www.text);
	}
}