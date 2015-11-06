using UnityEngine;
using System.Collections;

public class Blood : MonoBehaviour {

	public bool play;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (play) {
			play = false;
			GetComponent<AudioSource>().PlayOneShot(clip);
		}
	}
}
