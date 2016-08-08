using UnityEngine;
using System.Collections;

/*
http://answers.unity3d.com/questions/1079851/how-to-make-camera-follow-player-smoothly-on-x-axe.html
*/


public class Stage1Camera : MonoBehaviour {

	private Transform target;
	private float zPos;

	public Camera cameraMain;
	public Camera camera2;

	public bool cameraB = false;
	public static Stage1Camera main; 

	// Use this for initialization
	void Start () {

		//camera follow player
		target = GameObject.FindGameObjectWithTag ("Player").transform;

		//the default camera is the Main Camera
		cameraMain.enabled = true;
		camera2.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		main = this;
		//follow the z position of palyer
		zPos = Mathf.Lerp(transform.position.z, target.position.z,Time.deltaTime*8);
		//zPos = Mathf.Lerp(transform.position.z, target.position.z+4,Time.deltaTime*8); //need to fix

		transform.position = new Vector3(0, transform.position.y, zPos);

		//press z key to switch camera
		if (Input.GetKeyDown(KeyCode.Z))
		{
			cameraMain.enabled = !cameraMain.enabled;
			camera2.enabled = !camera2.enabled;
		}

		//when camera B is ative set bool cameraB to true
		if (camera2.enabled == true) {
			cameraB = true;
		} else {
			cameraB = false;
		}
	}
}
