using UnityEngine;
using System.Collections;
using MiniJSON;
using System.Collections.Generic;

public class logout : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick() {
		string pid = GlobalObject.getplayid ();
		string uid = GlobalObject.getuserid ();
		StartCoroutine (Post ("http://192.168.3.83:3000/users/logout", pid, uid));
	}

	IEnumerator Post(string url, string playid, string userid) {
		WWWForm form = new WWWForm();
		form.AddField("play_id", playid);
		form.AddField ("user_id", userid);
		
		WWW www = new WWW (url, form);
		yield return www;
		Debug.Log (www.text);

		Application.LoadLevel ("loginmenu");
	}

}
