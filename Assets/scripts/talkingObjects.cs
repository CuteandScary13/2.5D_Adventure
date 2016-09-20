using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class talkingObjects : MonoBehaviour {

	public float magDif = 5f;
	public Text myText;
	public Transform playerPos;
	public string advice = "Temp";
	// Update is called once per frame
	void Update () {
		if ((playerPos.position - transform.position).magnitude < magDif) {
			myText.text = advice;
		} else {
			myText.text = "";
		}
	}
}
