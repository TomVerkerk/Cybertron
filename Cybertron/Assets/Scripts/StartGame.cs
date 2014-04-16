using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public bool normal;
	public bool HARDCORE;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0) && normal)
		{
			Application.LoadLevel (1); 
		}

		if(Input.GetMouseButtonDown(1) && HARDCORE)
		{
			Application.LoadLevel (2); 
		}


	
	}
}
