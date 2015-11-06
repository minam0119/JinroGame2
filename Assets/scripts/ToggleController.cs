using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleController : MonoBehaviour {
	//public Toggle[] voteToggle = new Toggle[6];
	public Toggle[] voteToggle;
	//Toggle[] voteToggle = new Tovggle[6];
	public GameObject[] people;
	public bool isOn = false;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < people.Length; i++) {
			voteToggle[i].isOn = false;

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SelectedAugurA(){
		voteToggle[0].isOn = true;

		if(voteToggle[0].isOn){
			Destroy(people[0]);
		}
	}

	public void SelectedAugurB(){
		voteToggle[1].isOn = true;

		if(voteToggle[1].isOn){
			Destroy(people[1]);
		}
	}

	public void SelectedMedium(){
		voteToggle[2].isOn = true;

		if(voteToggle[2].isOn){
			GameManager.reibaishi.isDead = true;
		}
	}

	public void SelectedVillagerA(){
		voteToggle[3].isOn = true;

		if(voteToggle[3].isOn){
			Destroy(people[3]);
		}
	}

	public void SelectedVillagerB(){
		voteToggle[4].isOn = true;

		if(voteToggle[4].isOn){
			Destroy(people[4]);
		}
	}

	public void SelectedVillagerC(){
		voteToggle[5].isOn = true;

		if(voteToggle[5].isOn){
			Destroy(people[5]);
		}
	}
}
