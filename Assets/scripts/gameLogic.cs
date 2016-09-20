using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gameLogic : MonoBehaviour {
	bool hasWon = false;
	public float magDif = 5f;
	public Text myText;
	public Transform playerPos;
	public Transform treasurePos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hasWon) {
			myText.text = "YOU GOT TREASURE! YOU WIN!!!!";
		} else if ((playerPos.position-treasurePos.position).magnitude<magDif){
			myText.text = "Press [SPACE] to get treasure!";
			if (Input.GetKey (KeyCode.Space)) {
				hasWon = true;
			}
		}
	}
}
