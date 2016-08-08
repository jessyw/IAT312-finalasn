using UnityEngine;
using System.Collections;

/*
https://www.youtube.com/watch?v=pSN2x3dPgYw
*/

[RequireComponent (typeof (CharacterController))]
public class ScientistACopyFollow : MonoBehaviour {

	private CharacterController controller;
	private Quaternion tragerRotation;

	public float rotationSpeed = 450;
	public float walkSpeed = 6;

	// Use this for initialization
	void Start () {

		controller = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		//when cameraB is active
		if(Stage1Camera.main.cameraB == false){
			//direction
			Vector3 input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));

			if(input != Vector3.zero){
				//transform.rotation
				tragerRotation = Quaternion.LookRotation (input);
				transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle (transform.eulerAngles.y, tragerRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);
			}

			//movement
			Vector3 motion = input;
			motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1) ? .7f : 1;
			motion *= walkSpeed;
			motion += Vector3.up * -8;
			//slow down movement
			controller.Move (motion * Time.deltaTime);
		}
	}

}
