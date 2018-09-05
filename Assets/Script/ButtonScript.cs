using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
	private bool ModelRotestatic;
	private bool CameraMove;
	public GameObject CubeObject;
	// Use this for initialization
	void Start () {
		CameraMove = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (ModelRotestatic)
		{
			CubeObject.transform.Rotate(0,100*Time.deltaTime,0);
		}
		else
		{
			CubeObject.transform.Rotate(0,0,0);
		}


		if (CameraMove)
		{
			Camera.main.transform.Rotate(0,50*Time.deltaTime,0);
		}
		else
		{
			Camera.main.transform.Rotate(0,0,0);
		}
	}

	public void buttonScriptClick(GameObject ModelCube)
	{
		Debug.Log("Button Click");
		if (ModelCube.activeSelf)
		{
			ModelCube.SetActive(false);
		}
		else
		{
			ModelCube.SetActive(true);
		}
	}

	public void buttoCubeRote(GameObject ModelCube)
	{
		if (ModelRotestatic)
		{
			ModelRotestatic = false;
		}
		else
		{
			ModelRotestatic = true;
		}
	}

	public void buttonColor(string colorstring)
	{
		if (string.Compare(colorstring,"Red") == 0)
		{
			CubeObject.GetComponent<MeshRenderer>().material.color = Color.red;
		}
		if (string.Compare(colorstring,"Green") == 0)
		{
			CubeObject.GetComponent<MeshRenderer>().material.color = Color.green;
		}
		if (string.Compare(colorstring,"Blue") == 0)
		{
			CubeObject.GetComponent<MeshRenderer>().material.color = Color.blue;
		}
	}

	public void CameraSimARRotate()
	{
		if (CameraMove)
		{
			CameraMove = false;
		}
		else
		{
			CameraMove = true;
		}
	}
}
