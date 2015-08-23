using UnityEngine;
using System.Collections;

public class CreatePanel : MonoBehaviour {

	public GameObject panel;
	private GameObject panel_obj;
	private GameObject piece;
	private float offset = 50f;
	private RaycastHit2D hit;
	private Vector3 onestep;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void createpanel(int range, int direction) {
		piece = GlobalObject.getobject();
		for(int i = 0; i < range; i++) {		
			panel_obj = (GameObject)Instantiate(panel);
			panel_obj.transform.SetParent(piece.transform.parent);
			panel_obj.transform.localPosition = piece.transform.localPosition;
			switch(direction) {
			case 0:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x - offset, panel_obj.transform.localPosition.y - offset, 0f);
				break;
			case 1:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x, panel_obj.transform.localPosition.y - offset, 0f);
				break;
			case 2:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x + offset, panel_obj.transform.localPosition.y - offset, 0f);
				break;
			case 3:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x - offset, panel_obj.transform.localPosition.y, 0f);
				break;
			case 4:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x + offset, panel_obj.transform.localPosition.y, 0f);
				break;
			case 5:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x - offset, panel_obj.transform.localPosition.y + offset, 0f);
				break;
			case 6:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x, panel_obj.transform.localPosition.y + offset, 0f);
				break;
			case 7:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x + offset, panel_obj.transform.localPosition.y + offset, 0f);
				break;
			case 8:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x - offset, panel_obj.transform.localPosition.y + offset * 2f, 0f);
				break;
			case 9:
				panel_obj.transform.localPosition = new Vector3 (panel_obj.transform.localPosition.x + offset, panel_obj.transform.localPosition.y + offset * 2f, 0f);
				break;
			default:
				break;
			}
			offset += 50f;
		}
		offset = 50f;
	}

	/*public GameObject rayshot(int direction) {
		piece = (GameObject)Instantiate (panel);
		onestep = piece.transform.position;
		switch(direction) {
		case 0:
			onestep = new Vector3 (piece.transform.position.x - offset, piece.transform.position.y - offset, 0);
			hit = Physics2D.Raycast(onestep,  Quaternion(-45, Vector2.down));
			break;
		case 1:
			onestep = new Vector3 (piece.transform.position.x, piece.transform.position.y - offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.down);
			break;
		case 2:
			onestep = new Vector3 (piece.transform.position.x + offset, piece.transform.position.y - offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2(1, -1));
			break;
		case 3:
			onestep = new Vector3 (piece.transform.position.x - offset, piece.transform.position.y, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.left);
			break;
		case 4:
			onestep = new Vector3 (piece.transform.position.x + offset, piece.transform.position.y, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.right);
			break;
		case 5:
			onestep = new Vector3 (piece.transform.position.x - offset, piece.transform.position.y + offset, 0);
			 hit = Physics2D.Raycast(onestep,  Vector2(-1, 1));
			break;
		case 6:
			onestep = new Vector3 (piece.transform.position.x, piece.transform.position.y + offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.up);
			break;
		case 7:
			onestep = new Vector3 (piece.transform.position.x + offset, piece.transform.position.y + offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.down);
			break;
		case 8:
			onestep = new Vector3 (piece.transform.position.x - offset / 2f, piece.transform.position.y + offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2(-2, 3));
			break;
		case 9:
			onestep = new Vector3 (piece.transform.position.x + offset / 2f, piece.transform.position.y + offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2(2, 3));
			break;
		default:
			break;
		}
	}*/
}
