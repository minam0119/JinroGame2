using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Camera[] werewolfCamera;

	void Start(){
		//player = GameObject.Find("FirstPersonCharacter").GetComponent<Camera>();
		//werewolfCamera = GameObject.Find("Camera 1").GetComponent<Camera>();
		for(int i=0; i < werewolfCamera.Length; i++){
			werewolfCamera[i].enabled = false;
		}

	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Parson") {
			int number = int.Parse(other.gameObject.name.Substring(0,1));
			werewolfCamera[number].enabled = true;
		}
		
	}

	void OnTriggerExit (Collider other){
		
		if (other.gameObject.tag == "Parson") {
			int number = int.Parse(other.gameObject.name.Substring(0,1));
			werewolfCamera[number].enabled = false;
		}
		
		
	}
}
