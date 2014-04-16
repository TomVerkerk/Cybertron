using UnityEngine;
using System.Collections;

public class Pickup_Taker : MonoBehaviour {

	gun scriptE;
	Hpscript scriptF;

	void Start(){
		scriptE = GameObject.Find("Player").GetComponentInChildren<gun>();
		scriptF = GameObject.Find("HpText").GetComponentInChildren<Hpscript>();

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp") 
		{
			if(other.gameObject.name == "Ammobox(Clone)")
			{
				scriptE.aantalbullet = 10;
			}
			if(other.gameObject.name == "HpBox(Clone)")
			{
				scriptF.JouHp += 1;
			}
			Destroy(other.gameObject);
		}
	}
}
