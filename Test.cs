using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public float ali;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += new Vector3 (0,0,0);

		transform.eulerAngles += new Vector3 (0,0,0);

		transform.localScale += new Vector3 (0,0,0);

	}
}
