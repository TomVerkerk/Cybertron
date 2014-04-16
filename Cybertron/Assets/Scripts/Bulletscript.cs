using UnityEngine;
using System.Collections;

public class Bulletscript : MonoBehaviour {

	Score scriptA;
	public float bulletspeed = 0.01f;

	// Use this for initialization
	void Start () {
		scriptA = GameObject.Find("Scoretext").GetComponentInChildren<Score>();
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * bulletspeed);
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "wall")
		{
			Destroy(this.gameObject);
		}
		if (other.gameObject.tag == "enemy")
		{
			other.gameObject.GetComponent<EnemyBehaviour>().dead = true;
			other.gameObject.GetComponent<EnemyBehaviour>().roll = true;
			Destroy(this.gameObject);	
			scriptA.JouScore +=1;
		}
	}


}
