using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public bool attack;
	public bool melee;
	public Object hitBox;
	public GameObject enemyBullet;
	public GameObject aim;
	public float attackTimer;

	private GameObject player;
	private Vector3 playerDir;
	private float timer;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update()
	{
		if(attack == true)
		{
			timer ++;
			if(melee == true && timer > attackTimer)
			{
				playerDir = (player.transform.position - transform.position)/2;
				Instantiate(hitBox,transform.position+playerDir,transform.rotation);
				timer = 0;
			}
			if(melee == false && timer > attackTimer)
			{
				Instantiate(enemyBullet, aim.transform.position, aim.transform.rotation);
				timer = 0;
			}
		}
		else
		{
			timer = 0;
		}
	}
}
