using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Transform player;
	public Text textUI;

	string textUI = "You WIN";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance ( player.transform.position, transform.position) < 15f){


			GameLogic.GetComponent<Text>().text = textUI;
		
		}


	}


}
