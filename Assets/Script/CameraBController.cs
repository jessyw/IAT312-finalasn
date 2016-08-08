using UnityEngine;
using System.Collections;

public class CameraBController : MonoBehaviour {

	private float speed = 5.0f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
		if (Stage1Camera.main.cameraB == false) {
			if(Input.GetKey(KeyCode.DownArrow))
			{
				transform.position += new Vector3(0,-speed * Time.deltaTime,0);
			}
			if(Input.GetKey(KeyCode.UpArrow))
			{
				transform.position += new Vector3(0,speed * Time.deltaTime,0);
			}
		}
	}
}
