using UnityEngine;
using System.Collections;

public class FireAnimation : MonoBehaviour {

	public AnimationL animL;
	public Texture2D fireTex;

	// Use this for initialization
	void Start () {
		animL.Columns = 4;
		animL.Fps = 10;
		animL.Tex = fireTex;	
	}
	
	// Update is called once per frame
	void Update () {
		animL.Animate();
	}
}
