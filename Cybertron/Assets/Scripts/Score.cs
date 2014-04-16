using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public float JouScore = 0;

	// Use this for initialization
	void Start () {
		guiText.text = "Score:" + JouScore;
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score:" + JouScore;

	
	}
}
