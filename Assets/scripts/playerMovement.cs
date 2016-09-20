using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public Transform propeller;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			//main player stuff
			transform.position += new Vector3 (0, 0, 10f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 180, 0);
			//Propeller movement
			propeller.transform.eulerAngles += new Vector3 (0, 90f, 0)*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-10f, 0, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 90, 0);
			//Propeller movement
			propeller.transform.eulerAngles += new Vector3 (0, 90f, 0)*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0, 0, -10f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, 0, 0);
			//Propeller movement
			propeller.transform.eulerAngles += new Vector3 (0, 90f, 0)*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (10f, 0, 0f) * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, -90, 0);
			//Propeller movement
			propeller.transform.eulerAngles += new Vector3 (0, 90f, 0)*Time.deltaTime;
		}
		Camera.main.transform.position = transform.position + new Vector3 (0, 10f, 0);
	}
}
