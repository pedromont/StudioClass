using UnityEngine;
using System.Collections;

public class VectorInput : MonoBehaviour {

	// a public variable is exposed to the inspector and might be changed
	public float speed = 4.5f;

	public float shiftSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Transform>().position += new Vector3(0f, 0f, 1f);

		//this code below is framerate dependant, ergo the behaviour is different based on your framerate
		//transform.position += new Vector3 (0f, 0f, 1f);

		float actualSpeed = 5f;
		if (Input.GetKey (KeyCode.LeftShift)) {
			actualSpeed = shiftSpeed;
		} else {
			actualSpeed = actualSpeed;
		}

		if (Input.GetKey (KeyCode.W)) {

			// FRAMERATE INDEPENDANT, multiply Time times deltaTimes
			// Time.deltaTime = "fraction of a second in between a frame"
			// 60 FPS >> Time.deltaTime = ~16 ms
			// 10 FPS >> Time.deltaTime = ~100 ms
			transform.position += new Vector3 (0f, 0f, 1f) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0f, 0f, -1f) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-1f, 0f, 0f) * Time.deltaTime * actualSpeed;
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (1f, 0f, 0f) * Time.deltaTime * actualSpeed;
		}

	}
}
