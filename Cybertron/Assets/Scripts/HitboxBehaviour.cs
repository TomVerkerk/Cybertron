using UnityEngine;
using System.Collections;

public class HitboxBehaviour : MonoBehaviour {

	Hpscript scriptC;
	// Use this for initialization
	void Start () {
		scriptC = GameObject.Find("HpText").GetComponentInChildren<Hpscript>();
		Destroy(gameObject,0.1f);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player")
		{
			scriptC.JouHp -= 1;
		}
	}
}
