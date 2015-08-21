using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class Getinfo : MonoBehaviour {

	static string baseurl = "http://192.168.3.83:3000/plays/";
	static string pid = GlobalObject.getparam();
	string url_st = baseurl + pid + "/state";
	string url_us = baseurl + pid + "/users";
	string url_pl = baseurl + pid;
	string url_wi = baseurl + pid + "/winner";
	string url_pi = baseurl + pid + "/pieces";
	string[] statearray = new string[1];
	string[,] usersarray = new string[2, 2];
	string[] playarray = new string[4];
	string[] winnerarray = new string[1];
	string[,] piecearray = new string[40, 5];


	// Use this for initialization
	void Start () {
		StartCoroutine (Get ((url_st), 1));
		StartCoroutine (Get ((url_us), 2));
		StartCoroutine (Get ((url_pl), 3));
		StartCoroutine (Get ((url_wi), 4));
		StartCoroutine (Get ((url_pi), 5));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Get(string url, int kindinfo) {
		WWW www = new WWW (url);
		yield return www;

		var jsonData = Json.Deserialize(www.text) as Dictionary<string,object>;

		switch (kindinfo) {
		case 1:
			state_parse(jsonData);
			break;
		case 2:
			users_parse(jsonData);
			break;
		case 3:
			play_parse(jsonData);
			break;
		case 4:
			winner_parse(jsonData);
			break;
		case 5:
			piece_parse(jsonData);
			break;
		default: 
			break;
		}
	}

	
	void state_parse(Dictionary<string,object> json) {
		int i = 0;
		foreach(string Key in json.Keys) {
			//Debug.Log ("json[" + Key + "]=" + json[Key]);
			statearray[i] = json[Key].ToString();
			Debug.Log(statearray[i]);
		}
	}
	
	void users_parse(Dictionary<string,object> json) {
		int i = 0, j = 0;
		foreach (string firstKey in json.Keys) {
			//Debug.Log ("firstjson[" + firstKey + "]=" + json [firstKey]);
			Dictionary<string,object> valueDic = (Dictionary<string, object>)json[firstKey];
			foreach (string secondKey in valueDic.Keys) {
				//Debug.Log ("secondjson[" + secondKey + "]=" + valueDic[secondKey]);
				usersarray[i,j] = valueDic[secondKey].ToString();
				Debug.Log(usersarray[i,j]);
				j++;
			}
			i++;
		}
	}
	
	void play_parse(Dictionary<string,object> json) {
		int i = 0;
		foreach(string Key in json.Keys) {
			//Debug.Log ("json[" + Key + "]=" + json[Key]);
			playarray[i] = json[Key].ToString();
			Debug.Log (playarray[i]);
			i++;
		}
		i = 0;
	}
	
	void winner_parse(Dictionary<string,object> json) {
		int i = 0;
		foreach(string Key in json.Keys) {
			//Debug.Log ("json[" + Key + "]=" + json[Key]);
			if(json[Key] != null){
				winnerarray[i] = json[Key].ToString();
			}
		}
		i = 0;
	}

	void piece_parse(Dictionary<string,object> json) {
		int i = 0, j = 0;
		foreach (string firstKey in json.Keys) {
			//Debug.Log ("firstjson[" + firstKey + "]=" + json [firstKey]);
			Dictionary<string,object> valueDic = (Dictionary<string, object>)json [firstKey];
			foreach (string secondKey in valueDic.Keys) {
				//Debug.Log ("secondjson[" + secondKey + "]=" + valueDic [secondKey]);
				piecearray [i, j] = valueDic [secondKey].ToString ();
				Debug.Log (piecearray [i, j]);
				j++;
			}
			i++;
		}
	}

}