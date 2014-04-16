using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	public float attackSpeed;
	public float attackDistance;
	public float turnTime;
	public float runTime;
	public float enemytype;
	public EnemyAttack enemyAttack;
	private AnimationL animL;
	private AnimationR animR;
	public Texture2D enemy1walk;
	public Texture2D enemy1attack;
	public Texture2D enemy1death;
	public Texture2D enemy2walk;
	public Texture2D enemy2attack;
	public Texture2D enemy2death;
	public Texture2D enemy3walk;
	public Texture2D enemy3attack;
	public Texture2D enemy3death;
	public bool dead = false;
	public GameObject pickup1;
	public GameObject pickup2;
	public float randompickup;
	public bool roll = false;

	private GameObject player;
	private float timer = 0;
	private float distance;
	private float step;
	private Vector3 playerPos;

	// Use this for initialization
	void Start () {
		transform.rotation = Quaternion.Euler(Vector3.zero);
		player = GameObject.FindGameObjectWithTag("Player");
		animL = gameObject.GetComponent<AnimationL>();
		animR = gameObject.GetComponent<AnimationR>();
	}
	
	// Update is called once per frame
	void Update () {
		if(roll)
		{
			randomroll();
			roll = false;
		}
		if(randompickup <= 10 && randompickup >= 1)
		{
			Instantiate(pickup1, this.transform.position,this.transform.rotation);
			randompickup = 0;
		}
		if(randompickup <= 40 && randompickup >= 35)
		{
			Instantiate(pickup2, this.transform.position,this.transform.rotation);
			randompickup = 0;
		}
		if(enemytype == 1)
		{
			enemyAttack.melee = true;
			attackDistance = 4;
		}
		if(enemytype == 2)
		{
			enemyAttack.melee = false;
			attackDistance = 10;
		}
		if(enemytype == 3)
		{
			enemyAttack.melee = false;
			attackDistance = 15;
		}
		step = attackSpeed * Time.deltaTime;
		timer ++;
		distance = Vector3.Distance(transform.position,player.transform.position);
		if(timer == turnTime)
		{
			playerPos = player.transform.position;
		}
		if(timer > turnTime && timer <= runTime)
		{
			if(distance < 1 || enemyAttack.attack == true)
			{
				timer = runTime;
			}
			else
			{
				transform.position = Vector3.MoveTowards(transform.position,playerPos,step); // lerp?
			}
		}
		if(timer > runTime)
		{
			if(distance < attackDistance)
			{
				enemyAttack.attack = true;
			}
			else
			{
				enemyAttack.attack = false;
				timer = 0;
			}
		}

		if(dead == true)
		{
			enemyAttack.attack = false;
			if(player.transform.position.x - transform.position.x < 0)
			{
				if(enemytype == 1)
				{
					animR.Columns = 3;
					animR.Fps = 3;
					animR.Tex = enemy1death;
					animR.Animate();
					if(animR.index == 3)
					{
						Destroy(this.gameObject);
					}
				}
				if(enemytype == 2)
				{
					animR.Columns = 4;
					animR.Fps = 6;
					animR.Tex = enemy2death;
					animR.Animate();
					if(animR.index == 4)
					{

						Destroy(this.gameObject);
					}
				}
				if(enemytype == 3)
				{
					animR.Columns = 5;
					animR.Fps = 6;
					animR.Tex = enemy3death;
					animR.Animate();
					if(animR.index == 4)
					{

						Destroy(this.gameObject);
					}
				}
			}
			else
			{
				if(enemytype == 1)
				{
					animL.Columns = 3;
					animL.Fps = 3;
					animL.Tex = enemy1death;
					animL.Animate();
					if(animL.index == 4)
					{
						Destroy(this.gameObject);
					}
				}
				if(enemytype == 2)
				{
					animL.Columns = 4;
					animL.Fps = 6;
					animL.Tex = enemy2death;
					animL.Animate();
					if(animL.index == 4)
					{
						Destroy(this.gameObject);
					}
				}
				if(enemytype == 3)
				{
					animL.Columns = 5;
					animL.Fps = 6;
					animL.Tex = enemy3death;
					animL.Animate();
					if(animL.index == 8)
					{
						Destroy(this.gameObject);
					}
				}
			}
		}
		else if(enemyAttack.attack == false)
		{
			if(player.transform.position.x - transform.position.x < 0)
			{
				if(enemytype == 1)
				{
					animR.Columns = 3;
					animR.Fps = 6;
					animR.Tex = enemy1walk;
					//animR.extraOffsetY = 0.018f;
					animR.Animate();
				}
				if(enemytype == 2)
				{
					animR.Columns = 3;
					animR.Fps = 6;
					animR.Tex = enemy2walk;
					//animR.extraOffsetY = 0.018f;
					animR.Animate();
				}
				if(enemytype == 3)
				{
					animR.Columns = 5;
					animR.Fps = 6;
					animR.Tex = enemy3walk;
					//animR.extraOffsetY = 0.018f;
					animR.Animate();
				}
			}
			else
			{
				if(enemytype == 1)
				{
					animL.Columns = 3;
					animL.Fps = 6;
					animL.Tex = enemy1walk;
					//animR.extraOffsetY = 0.018f;
					animL.Animate();
				}
				if(enemytype == 2)
				{
					animL.Columns = 3;
					animL.Fps = 6;
					animL.Tex = enemy2walk;
					//animR.extraOffsetY = 0.018f;
					animL.Animate();
				}
				if(enemytype == 3)
				{
					animL.Columns = 5;
					animL.Fps = 6;
					animL.Tex = enemy3walk;
					//animR.extraOffsetY = 0.018f;
					animL.Animate();
				}
			}
		}
		else
		{
			if(player.transform.position.x - transform.position.x < 0)
			{
				if(enemytype == 1)
				{
					animR.Columns = 5;
					animR.Fps = 10;
					animR.Tex = enemy1attack;
					animR.extraOffsetX = 0.026f;
					animR.Animate();
				}
				if(enemytype == 2)
				{
					animR.Columns = 3;
					animR.Fps = 10;
					animR.Tex = enemy2attack;
					//animR.extraOffsetX = 0.015f;
					animR.Animate();
				}
				if(enemytype == 3)
				{
					animR.Columns = 4;
					animR.Fps = 10;
					animR.Tex = enemy3attack;
					//animR.extraOffsetX = 0.015f;
					animR.Animate();
				}
			}
			else
			{
				if(enemytype == 1)
				{
					animL.Columns = 5;
					animL.Fps = 10;
					animL.Tex = enemy1attack;
					animR.extraOffsetX = 0.026f;
					animL.Animate();
				}
				if(enemytype == 2)
				{
					animL.Columns = 3;
					animL.Fps = 10;
					animL.Tex = enemy2attack;
					//animR.extraOffsetX = 0.015f;
					animL.Animate();
				}
				if(enemytype == 3)
				{
					animL.Columns = 4;
					animL.Fps = 10;
					animL.Tex = enemy3attack;
					//animR.extraOffsetX = 0.015f;
					animL.Animate();
				}
			}
		}
	}
	void randomroll()
	{
		randompickup = Random.Range(0,100);
		print(randompickup);
	}
}
