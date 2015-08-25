using UnityEngine;
using System.Collections;

public class GlobalObject : MonoBehaviour {

	private static string saveplayid;
	private static string saveuserid;
	private static GameObject saveobject;
	private static string[] savestate = new string[1];
	private static string[,] saveusers = new string[2, 2];
	private static string[] saveplay = new string[4];
	private static string[] savewinner = new string[1];
	private static string[,] savepiece = new string[40, 5];
	private static string[] savepieceid = new string[40];
	public static int overlap_flag = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void setplayid(string playid) {
		saveplayid = playid;
	}

	public static void setuserid(string userid) {
		saveuserid = userid;
	}

	public static void setobject(GameObject tappiece) {
		saveobject = tappiece;
	}

	public static void setstate(string[] state) {
		savestate = state;
	}

	public static void setusers(string[,] users) {
		saveusers = users;
	}

	public static void setplay(string[] play) {
		saveplay = play;
	}

	public static void setwinner(string[] winner) {
		savewinner = winner;
	}

	public static void setpiece(string[,] piece) {
		savepiece = piece;
	}

	public static void setpieceid(string[] pieceid) {
		savepieceid = pieceid;
	}

	public static string getplayid() {
		return saveplayid;
	}

	public static string getuserid() {
		return saveuserid;
	}

	public static GameObject getobject() {
		return saveobject;
	}

	public static string[] getstate() {
		return savestate;
	}

	public static string[,] getusers() {
		return saveusers;
	}

	public static string[] getplay() {
		return saveplay;
	}

	public static string[] getwinner() {
		return savewinner;
	}

	public static string[,] getpiece() {
		return savepiece;
	}

	public static string[] getpieceid() {
		return savepieceid;
	}
}

