using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	public GameObject player;
	private float x;
	private float y;
	private float movementSpeed;
	private Vector3 camPos;

	// Use this for initialization
	void Start () {
		camPos = new Vector3(0.07720566f,3.703136f,-0.4650044f);
		movementSpeed = player.GetComponent<Player_Movement>().movementSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.x >= 27.6f)
		{
			if(player.transform.position.z >= 40.9f)
			{
				transform.position = new Vector3(27.6f,4.583136f,40.9f);
			}
			else if(player.transform.position.z <= -40.6f)
			{
				transform.position = new Vector3(27.6f,4.583136f,-40.6f);
			}
			else
			{
				transform.position = new Vector3(27.6f,4.583136f,player.transform.position.z);
			}
		}
		else if(player.transform.position.x <= -27.67f)
		{
			if(player.transform.position.z >= 40.9f)
			{
				transform.position = new Vector3(-27.67f,4.583136f,40.9f);
			}
			else if(player.transform.position.z <= -40.6f)
			{
				transform.position = new Vector3(-27.67f,4.583136f,-40.6f);
			}
			else
			{
				transform.position = new Vector3(-27.6f,4.583136f,player.transform.position.z);
			}
		}
		else if(player.transform.position.z >= 40.9f)
		{
			transform.position = new Vector3(player.transform.position.x,4.583136f,40.9f);
		}
		else if(player.transform.position.z <= -40.6f)
		{
			transform.position = new Vector3(player.transform.position.x,4.583136f,-40.6f);
		}
		else
		{
			transform.position = camPos + player.transform.position;
		}
	}
}
