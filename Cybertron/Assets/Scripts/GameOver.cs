using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GUITexture gameover;
	private float timer;

	// Use this for initialization
	void Start () {
		gameover.pixelInset = new Rect(0,0,Screen.width,Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		Debug.Log(timer);
		if(timer > 300)
		{
			Application.LoadLevel(0);
		}
	}
}
