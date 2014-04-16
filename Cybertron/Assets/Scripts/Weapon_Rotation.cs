using UnityEngine;
using System.Collections;

public class Weapon_Rotation : MonoBehaviour {

	private float rotationSpeed = 5;
	private float hitdist = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Plane playerPlane = new Plane (Vector3.up, transform.position);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		if(playerPlane.Raycast(ray, out hitdist))
		{
			Vector3 targetPoint = ray.GetPoint(hitdist);
			Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.time);
		}

	}
}
