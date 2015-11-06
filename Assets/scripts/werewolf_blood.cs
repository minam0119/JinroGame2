using UnityEngine;
using System.Collections;

public class werewolf_blood : MonoBehaviour {
	float time = 6;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if(time <= 0){
			Application.LoadLevel("blood2");
		}
	}
}
