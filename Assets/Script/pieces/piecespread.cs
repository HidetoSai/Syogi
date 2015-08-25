using UnityEngine;
using System.Collections;

public class piecespread : MonoBehaviour {

	private GameObject piece;
	private string uid;
	private string[] playinfo = new string[4];
	private string[,] pieceinfo = new string[40, 5];
	private string[] pieceid = new string[40];
	int count = 2;

	public GameObject al_Fu;
	public GameObject al_Kyosya;
	public GameObject al_Keima;
	public GameObject al_Gin;
	public GameObject al_Kin;
	public GameObject al_Kaku;
	public GameObject al_Hisya;
	public GameObject al_Ou;
	public GameObject al_FuNari;
	public GameObject al_KyosyaNari;
	public GameObject al_KeimaNari;
	public GameObject al_GinNari;
	public GameObject al_Uma;
	public GameObject al_Ryu;
	public GameObject en_Fu;
	public GameObject en_Kyosya;
	public GameObject en_Keima;
	public GameObject en_Gin;
	public GameObject en_Kin;
	public GameObject en_Kaku;
	public GameObject en_Hisya;
	public GameObject en_Ou;
	public GameObject en_FuNari;
	public GameObject en_KyosyaNari;
	public GameObject en_KeimaNari;
	public GameObject en_GinNari;
	public GameObject en_Uma;
	public GameObject en_Ryu;


	// Use this for initialization
	void Start () {
		uid = GlobalObject.getuserid ();
		Invoke("replace", 0.4f);
	}
	
	// Update is called once per frame
	void Update () {
		playinfo = GlobalObject.getplay ();
		if(int.Parse(playinfo[0]) == count){
			var clones = GameObject.FindGameObjectsWithTag ("Koma");
			foreach (var clone in clones) {
				Destroy (clone);
			}
			replace();
			count++;
		}
	}

	void replace() {
		pieceinfo = GlobalObject.getpiece ();
		pieceid = GlobalObject.getpieceid ();
		for (int i = 0; i < pieceinfo.GetLength(0); i++) {
			switch (pieceinfo [i, 0]) {
			case "fu":
				if (pieceinfo [i, 3] == uid) {
					if (pieceinfo [i, 4] == "False") {
						createpiece (al_Fu, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (al_FuNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				} else {
					if (pieceinfo [i, 4] == "False") {
						createpiece (en_Fu, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (en_FuNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				}
				break;
			case "kyosha":
				if (pieceinfo [i, 3] == uid) {
					if (pieceinfo [i, 4] == "False") {
						createpiece (al_Kyosya, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (al_KyosyaNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				} else {
					if (pieceinfo [i, 4] == "False") {
						createpiece (en_Kyosya, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (en_KyosyaNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				}
				break;
			case "keima":
				if (pieceinfo [i, 3] == uid) {
					if (pieceinfo [i, 4] == "False") {
						createpiece (al_Keima, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (al_KeimaNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				} else {
					if (pieceinfo [i, 4] == "False") {
						createpiece (en_Keima, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (en_KeimaNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				}
				break;
			case "gin":
				if (pieceinfo [i, 3] == uid) {
					if (pieceinfo [i, 4] == "False") {
						createpiece (al_Gin, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (al_GinNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				} else {
					if (pieceinfo [i, 4] == "False") {
						createpiece (en_Gin, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (en_GinNari, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				}
				break;
			case "kin":
				if (pieceinfo [i, 3] == uid) {
					createpiece (al_Kin, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
				} else {
					createpiece (en_Kin, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
				}
				break;
			case "oh":
				if (pieceinfo [i, 3] == uid) {
					createpiece (al_Ou, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
				} else {
					createpiece (en_Ou, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
				}
				break;
			case "kaku":
				if (pieceinfo [i, 3] == uid) {
					if (pieceinfo [i, 4] == "False") {
						createpiece (al_Kaku, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (al_Uma, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				} else {
					if (pieceinfo [i, 4] == "False") {
						createpiece (en_Kaku, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (en_Uma, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				}
				break;
			case "hisha":
				if (pieceinfo [i, 3] == uid) {
					if (pieceinfo [i, 4] == "False") {
						createpiece (al_Hisya, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (al_Ryu, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				} else {
					if (pieceinfo [i, 4] == "False") {
						createpiece (en_Hisya, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					} else {
						createpiece (en_Ryu, float.Parse (pieceinfo [i, 1]), float.Parse (pieceinfo [i, 2]), pieceid[i]);
					}
				}
				break;
			default:
				break;
			}
		}
	}

	void createpiece(GameObject piece, float posx, float posy, string id) {
		GameObject obj = (GameObject)Instantiate (piece);
		obj.transform.SetParent (this.transform.parent);
		obj.transform.localPosition = new Vector3 (changetable.changeposition(posx), changetable.changeposition(posy), 0);
		obj.transform.name = id;
	}
}

