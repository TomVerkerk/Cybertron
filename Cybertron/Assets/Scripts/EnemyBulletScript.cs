using UnityEngine;
using System.Collections;

public class EnemyBulletScript : MonoBehaviour {

	Hpscript scriptB;
	public float bulletspeed = 0.2f;

	
	// Use this for initialization
	void Start () {

		scriptB = GameObject.Find("HpText").GetComponentInChildren<Hpscript>();

		
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
		if (other.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
			scriptB.JouHp -= 1;

		}
	}
	
	
}
