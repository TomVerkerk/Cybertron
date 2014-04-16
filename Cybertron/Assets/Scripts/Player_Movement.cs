using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

	public AnimationL animL;
	public AnimationR animR;
	public Texture2D walk;
	public Texture2D idle;
	public Texture2D deadTex;
	public float movementSpeed;
	private float x;
	private float y;
	private bool left;
	public bool dead = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		x = Input.GetAxis ("Horizontal");
		y = Input.GetAxis ("Vertical");
		if(dead == true)
		{
			animR.Columns=13;
			animR.Fps = 5;
			animR.Tex = deadTex;
			animR.Animate();
			if(animR.index == 13)
			{
				Application.LoadLevel(2);
			}
		}
		else
		{
			transform.Translate (new Vector3(x, 0, y) * movementSpeed * Time.deltaTime);
			if(x>0)
			{
				left = false;
				animR.Columns = 8;
				animR.Fps = 7;
				//animR.extraOffsetY = 0.009f;
				animR.Tex = walk;
				animR.Animate();
			}
			if(x<0)
			{
				left = true;
				animL.Columns = 8;
				animL.Fps = 7;
				//animL.extraOffsetY = 0.009f;
				animL.Tex = walk;
				animL.Animate();
			}
			if(y != 0 && x == 0)
			{
				if(left == true)
				{
					animL.Columns = 8;
					animL.Fps = 7;
					//animL.extraOffsetY = 0.08f;
					animL.Tex = walk;
					animL.Animate();
				}
				else
				{
					animR.Columns = 8;
					animR.Fps = 7;
					//animR.extraOffsetY = 0.08f;
					animR.Tex = walk;
					animR.Animate();
				}
			}
			if(x == 0 && y == 0)
			{
				if(left == true)
				{
					animL.Columns = 4;
					animL.Fps = 4;
					animL.extraOffsetY = -0.005f;
					animL.Tex = idle;
					animL.Animate();
				}
				else
				{
					animR.Columns = 4;
					animR.Fps = 4;
					animR.extraOffsetY = -0.005f;
					animR.Tex = idle;
					animR.Animate();
				}
			}
		}

	}
}
