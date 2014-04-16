using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	private GameObject playerpos;

	void Start(){
		playerpos = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		this.transform.LookAt(playerpos.transform.position);
			
	}
}
