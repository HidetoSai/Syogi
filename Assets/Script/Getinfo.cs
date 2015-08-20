using UnityEngine;
using System.Collections;

public class Getinfo : MonoBehaviour {

	static string baseurl = "http://192.168.3.83:3000/plays/";
	static string pid = GlobalObject.getparam();
	string url_st = baseurl + pid + "/state";
	string url_us = baseurl + pid + "/users";
	string url_pl = baseurl + pid;
	string url_wi = baseurl + pid + "/winner";
	string url_pi = baseurl + pid + "/pieces";

	// Use this for initialization
	void Start () {
		StartCoroutine (Get (url_st));
		StartCoroutine (Get (url_us));
		StartCoroutine (Get (url_pl));
		StartCoroutine (Get (url_wi));
		StartCoroutine (Get (url_pi));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Get(string url) {
		WWW www = new WWW (url);
		yield return www;
		if (www.error != null) {
			Debug.Log ("Error");
		} else {
			Debug.Log (www.text);
		}
	}

	/*public WWW Get(string url) {
		WWW www = new WWW (url);
		StartCoroutine (WaitForRequest (www));
		return www;
	}

	private IEnumerator WaitForRequest(WWW www) {
		yield return www;
		if (www.error == null) {
			Debug.Log("WWW Ok!: " + www.text);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}
	}*/
}
