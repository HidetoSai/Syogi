using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using MiniJSON;

public class login : MonoBehaviour {

	public Text pname;
	public Text rnumber;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			StartCoroutine (Post("http://192.168.3.83:3000/users/login/"));
		}
	}
	public void OnClick() {
		StartCoroutine (Post ("http://192.168.3.83:3000/users/login/"));
	}
	
	IEnumerator Post(string url) {
		WWWForm form = new WWWForm();
		form.AddField("name", pname.text);
		form.AddField ("room_no", rnumber.text);

		WWW www = new WWW (url, form);
		yield return www;
		Debug.Log (www.text);

		var jsonData = Json.Deserialize(www.text) as Dictionary<string,object>;
		string pid = jsonData["play_id"].ToString();

		GlobalObject.setparam (pid);
		Application.LoadLevel ("playscene");
	}
}

