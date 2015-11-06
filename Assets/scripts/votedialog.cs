using UnityEngine;
using System.Collections;

public class votedialog : MonoBehaviour {
	public GameObject dialog1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	 public void Touch(){
		dialog1.SetActive(true);
	}

	public void Cancellog(){
		dialog1.SetActive(false);
	}
}
