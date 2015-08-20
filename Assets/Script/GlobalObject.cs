using UnityEngine;
using System.Collections;

public class GlobalObject : MonoBehaviour {

	private static string saveparam;
	private static GameObject saveobject;
	public static int overlap_flag = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void setparam(string param) {
		saveparam = param;
	}

	public static void setobject(GameObject tappiece) {
		saveobject = tappiece;
	}

	public static string getparam() {
		return saveparam;
	}

	public static GameObject getobject() {
		return saveobject;
	}
}

