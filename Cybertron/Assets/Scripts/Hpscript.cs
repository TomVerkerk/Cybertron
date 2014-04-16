using UnityEngine;
using System.Collections;

public class Hpscript : MonoBehaviour {

	public float JouHp = 10;
	public Player_Movement player;

	// Use this for initialization
	void Start () {
		guiText.text = "Hp:" + JouHp;
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Hp:" + JouHp;
		if(JouHp <= 0)
		{
			JouHp = 0;
			player.dead = true;
		}
	}
}
