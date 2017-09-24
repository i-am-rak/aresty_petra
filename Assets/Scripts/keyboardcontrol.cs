using UnityEngine;
using System.Collections;

//public float speed = 5.0f;

public class keyboardcontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// Update is called once per frame

	}
	

	void Update()
	{
		if(Input.GetKey("d"))
		{
			transform.Translate(new Vector3(5 * Time.deltaTime,0,0));
		}
		if(Input.GetKey("a"))
		{
			transform.Translate(new Vector3(-5 * Time.deltaTime,0,0));
		}
		if(Input.GetKey("s"))
		{
			transform.Translate(new Vector3(0,-5 * Time.deltaTime,0));
		}
		if(Input.GetKey("w"))
		{
			transform.Translate(new Vector3(0,5 * Time.deltaTime,0));
		}
	}
}
