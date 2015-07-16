using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	public Transform player;
	string textBuffer = "You WIN";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GameLogic.GetComponent<Text>().text = textBuffer;
	}


}
