using UnityEngine;
using System.Collections;

public class Ammo : MonoBehaviour {

	public gun gun;

	// Use this for initialization
	void Start () {
		guiText.text = "Ammo:" + gun.aantalbullet+"/10";
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Ammo:" + gun.aantalbullet+"/10";
	}
}
