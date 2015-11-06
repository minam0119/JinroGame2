using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectedCharacter : MonoBehaviour {

	Text augurAText;
	Text augurBText;
	Text MediumText;
	Text villagerAText;
	Text villagerBText;
	Text villagerCText;

	[System.Serializable]
	public class Person {
		public string name;
		public Person (string name) {
			this.name = name;
		}
	}

	public Person[] persons;
	Text deathText;


	// Use this for initialization
	void Start () {
		/*print (GameObject.Find("AugurA_Label"));
		augurAText = GameObject.Find("AugurA_Label").GetComponent<Text>();
		augurBText = GameObject.Find("Label_AugurB").GetComponent<Text>();
		MediumText = GameObject.Find("Label_Medium").GetComponent<Text>();
		villagerAText = GameObject.Find("Label_VillagerA").GetComponent<Text>();
		villagerBText = GameObject.Find("Label_VillagerB").GetComponent<Text>();
		villagerCText = GameObject.Find("Label_VillagerC").GetComponent<Text>();*/
		
		//print(augurBText.text);

	}
	
	// Update is called once per frame
	void Update () {
		/*deathText.text = persons[0].name =  "が処刑されました。";
		deathText.text = persons[1].name = "占い師Bが処刑されました。";
		deathText.text = persons[2].name = "霊媒師が処刑されました。";
		deathText.text = persons[3].name = "村人Aが処刑されました。";
		deathText.text = persons[4].name = "村人Bが処刑されました。";
		deathText.text = persons[5].name = "村人Cが処刑されました。";*/
	}
}

	
