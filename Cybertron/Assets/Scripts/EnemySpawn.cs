using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public float spawngroup = 3;
	public float maxspawngroup = 3;
	public GameObject spawnenemy;
	public GameObject spawnenemy2;
	public GameObject spawnenemy3;
	public GameObject currentenemy;
	public bool groupspawn = true;
	public Transform spawnplek1;
	public Transform spawnplek2;
	public Transform spawnplek3;
	public Transform spawnplek4;
	public Transform spawnplek5;
	public Transform spawnplek6;
	public Transform spawnplek7;
	public Transform spawnplek8;
	public Transform spawnplek9;
	public Transform spawnplek;
	public float enemies = 10;
	public float totalenemies = 10;
	public bool foreverspawn = false;
	public Transform Randomspawnplek;
	public float dob;
	public bool isnul = false;


	// Use this for initialization
	void Start () {
		currentenemy = spawnenemy;
	

	
	}
	
	// Update is called once per frame
	void Update () {
		if(isnul == true)
		{
			print("lala");

		}

		if(enemies == 0)
		{
			enemies = totalenemies + 10;
			totalenemies += enemies;
			spawngroup = 3;
			maxspawngroup = 3;

		}

		if(groupspawn == false)
		{
			StartCoroutine("starttijd");
		}
		if(spawngroup == 0)
		{
			groupspawn = false;
		}

		if (enemies >= 1 && groupspawn && foreverspawn == false)
		{

			spawngroup -= 1;
			enemies -= 1;
			Instantiate(currentenemy, Randomspawnplek.transform.position, Randomspawnplek.transform.rotation); 
			dobbelen();
		}
		if (foreverspawn) {
			Instantiate(spawnenemy, Randomspawnplek.transform.position, Randomspawnplek.transform.rotation); 
			dobbelen();
				}
			            }
	void dobbelen(){
		dob = Random.Range(0,9);
		if(dob == 0)
		{
			Randomspawnplek = spawnplek;
			currentenemy = spawnenemy;
			}

		if(dob == 1)
			{
			Randomspawnplek = spawnplek1;
			currentenemy = spawnenemy;
			}

		if(dob == 2)
			{
			Randomspawnplek = spawnplek2;
			currentenemy = spawnenemy;
			}

		if(dob == 3)
			{
			Randomspawnplek = spawnplek3;
			currentenemy = spawnenemy2;
			}

		if(dob == 4)
			{
			Randomspawnplek = spawnplek4;
			currentenemy = spawnenemy2;
			}

		if(dob == 5)
			{	
			Randomspawnplek = spawnplek5;
			currentenemy = spawnenemy3;
			}

		if(dob == 6)
			{	
			Randomspawnplek = spawnplek6;
			currentenemy = spawnenemy3;
			}

		if(dob == 7)
			{	
			Randomspawnplek = spawnplek7;
			currentenemy = spawnenemy;
			}

		if(dob == 8)
			{	
			Randomspawnplek = spawnplek8;
			currentenemy = spawnenemy;
			}

		if(dob == 9)
			{	
			Randomspawnplek = spawnplek9;
			currentenemy = spawnenemy;
			}


	}
			IEnumerator starttijd(){
				yield return new WaitForSeconds(7);
				maxspawngroup = maxspawngroup + 2;
				spawngroup = maxspawngroup;
				groupspawn = true;
				StopCoroutine("starttijd");
			}

}
