using UnityEngine;
using System.Collections;

public class SecurityCameraControl : MonoBehaviour {

	//set the game object to camera range
	public GameObject range;

	//boolean of mouse enter
	bool enter = false;

	// Use this for initialization
	void Start () {
	
		//turn off camera range visibality 
		range.SetActive(false); 
	}
	
	// Update is called once per frame
	void Update () {

		//when mouse enter turn on camera range visibality
		if (enter == true) {
			range.SetActive (true);
		} else {
			range.SetActive (false);
		}
	}

	//mouse enter 
	void OnMouseOver(){
		enter = true;
	}

	//mouse exit
	void OnMouseExit(){
		enter = false;
	}
		
}
