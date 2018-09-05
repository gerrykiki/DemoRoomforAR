using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayFunction : MonoBehaviour {
	private bool isMouseDrag;
	public GameObject ModelTarget;
	//public Material ModelTargetMaterial;
	// Use this for initialization
	void Start () {
		isMouseDrag = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			isMouseDrag = true;
		}

		if (Input.GetMouseButtonUp(0))
		{
			isMouseDrag = false;
		}
		//Mouse drag time
		if (isMouseDrag)
		{
			Ray MouseRayPoint = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit MouseRayHit;
			if(Physics.Raycast(MouseRayPoint,out MouseRayHit))
			{
				Vector3 mousePoint = Input.mousePosition;
				mousePoint.z = 10;
				Vector3 WorldMousePoint = Camera.main.ScreenToWorldPoint(mousePoint);
				ModelTarget.transform.position = WorldMousePoint;
			}
			
		}
		//ModelTarget.transform.Rotate(0,100*Time.deltaTime,0);
	}
}
