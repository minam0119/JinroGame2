using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using JinroGame;

public class CharacterViewController : MonoBehaviour {

	public Text talkLabel;
	public bool dead;
	public int role,actRole,job;
	public PlayerViewController player;
	public GameObject talkCameraObj;
	string talkContent;
	//job 0村人A 1村人B 2占い師B 3村人D(人狼) 5占い師A 6村人C

	public void ShowTalk(string talks){
		talkLabel = gameObject.transform.FindChild("CharacterCamera")
			.FindChild("Canvas").FindChild("TalkWindow").FindChild("TalkLabel").GetComponent<Text>();
		StartCoroutine(SetText(talkLabel,talks));
	}

	IEnumerator SetText(Text label,string text){
		string[] bunkatu = text.Split('|');
		text = "";
		for (int i=0; i<bunkatu.Length; i++) {
			if (bunkatu[i] == "<kaigyou>") {
				text += "\n";
			} else {
				text += bunkatu[i];
			}
		}
		for(int i=0;i<=text.Length; i++){
			label.text = text.Substring(0,i);
			yield return new WaitForSeconds(0.04f);
		}
	}

}