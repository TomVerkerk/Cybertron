using UnityEngine;
using System.Collections;

public class AnimationR : MonoBehaviour {

	public int index;
	public Texture2D Tex;
	public int Columns;
	public int Fps;
	private float offsetX;
	public float extraOffsetX;
	public float extraOffsetY;
	private Texture2D myTexture;

	public void Animate()
	{
		index = (int)(Fps * Time.time);
		index = index % Columns;
		index = Columns - index;

		float rightX = 1f /Columns;
		Vector2 size = new Vector2(rightX, 1);
		
		myTexture = new Texture2D((int)rightX, (int)1);
		myTexture = Tex;
		
		offsetX = (index * rightX) + (extraOffsetX);
		Vector2 offset = new Vector2(offsetX, extraOffsetY);
		
		renderer.material.mainTexture = myTexture;
		renderer.material.SetTextureScale("_MainTex", size);
		renderer.material.SetTextureOffset("_MainTex", offset);
	}
}
