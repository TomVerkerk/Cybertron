using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public GUITexture menu;

	// Use this for initialization
	void Start () {
		menu.pixelInset = new Rect(0,0,Screen.width,Screen.height);
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.color = Color.clear;
		if(GUI.Button(new Rect(Screen.width*0.36f,Screen.height*0.14f,Screen.width*0.26f,Screen.height*0.23f),""))
		{
			Application.LoadLevel(1);
		}
	
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
