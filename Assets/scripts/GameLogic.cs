using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Transform player;
	public Text textUI;

	//string textUI = "You WIN";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space) && (Vector3.Distance ( player.transform.position, transform.position) < 15f)){

			GetComponent<Text>().text = "You WIN";
		
		}


	}


}
