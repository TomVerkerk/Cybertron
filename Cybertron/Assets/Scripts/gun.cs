using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {
	
	public float speed = 45.5f;
	public Transform bulletspawn;
	public GameObject bull;
	public AnimationL animL;
	public Texture2D tex;
	public float aantalbullet = 10;
	private bool reloading = false;
	public bool AK;
	public bool pistol;
	// Use this for initialization

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		animL.Columns = 4;
		animL.Fps = 2;
		animL.Tex = tex;
		animL.Animate();
		if (Input.GetMouseButtonDown(0) && aantalbullet > 0 && pistol && reloading == false)
		{
			Instantiate(bull, bulletspawn.transform.position, bulletspawn.transform.rotation);	
			aantalbullet -=1;
			audio.Play();
		}
		if (Input.GetMouseButton(0) && AK)
		{
			Instantiate(bull, bulletspawn.transform.position, bulletspawn.transform.rotation);	
			//aantalbullet -=1;
		}
		if(Input.GetKeyDown(KeyCode.R) && reloading == false)
		{
			StartCoroutine(reload());
			reloading = true;
		}

		if(aantalbullet == 0 && reloading == false)
		{
			StartCoroutine(reload());
			reloading = true;
		}

		}
	
		IEnumerator reload () {
		yield return new WaitForSeconds(2);
		aantalbullet = 10;
		reloading = false;
		}
}
