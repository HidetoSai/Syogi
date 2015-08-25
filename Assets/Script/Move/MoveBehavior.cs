using UnityEngine;
using System.Collections;

public class MoveBehavior : MonoBehaviour {

	public GameObject panel;
	private GameObject panel_obj;
	private GameObject piece;
	private float offset = 50f;
	RaycastHit2D hit;
	Vector3 onestep;

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

	public Collider2D rayshot(int direction) {
		piece = GlobalObject.getobject ();
		onestep = piece.transform.position;
		switch(direction) {
		case 0:
			onestep = new Vector3 (piece.transform.position.x - offset, piece.transform.position.y - offset, 0);
			Vector2 dir0 = new Vector2(-1, -1);
			hit = Physics2D.Raycast(onestep,  dir0);
			break;
		case 1:
			onestep = new Vector3 (piece.transform.position.x, piece.transform.position.y - offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.down);
			break;
		case 2:
			onestep = new Vector3 (piece.transform.position.x + offset, piece.transform.position.y - offset, 0);
			Vector2 dir2 = new Vector2(1, -1);
			hit = Physics2D.Raycast(onestep,  dir2);
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
			Vector2 dir5 = new Vector2(-1, 1);
			hit = Physics2D.Raycast(onestep, dir5);
			break;
		case 6:
			onestep = new Vector3 (piece.transform.position.x, piece.transform.position.y + offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.up);
			break;
		case 7:
			onestep = new Vector3 (piece.transform.position.x + offset, piece.transform.position.y + offset, 0);
			hit = Physics2D.Raycast(onestep,  Vector2.one);
			break;
		case 8:
			onestep = new Vector3 (piece.transform.position.x - offset / 2f, piece.transform.position.y + offset, 0);
			Vector2 dir8 = new Vector2(2, -3);
			hit = Physics2D.Raycast(onestep,  dir8);
			break;
		case 9:
			onestep = new Vector3 (piece.transform.position.x + offset / 2f, piece.transform.position.y + offset, 0);
			Vector2 dir9 = new Vector2(2, 3);
			hit = Physics2D.Raycast(onestep,  dir9);
			break;
		default:
			break;
		}
		return hit.collider;
	}
}
