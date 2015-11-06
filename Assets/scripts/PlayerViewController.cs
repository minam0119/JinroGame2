using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerViewController : MonoBehaviour {
	int[] TalkPerson;
	int[] ToldPerson;
	TalkManager talkManager;
	StageManager stageManager;
	public List<CharacterViewController> character = new List<CharacterViewController>();
	GameObject[] charas;
	FirstPersonController fpController;
	List<string> log = new List<string>();
	List<string> detailNewLine = new List<string>();

	public int col;
	string pushTalk;


	public int  col_villagerA = 1,
				col_villagerB = 1,
				col_villagerC = 1,
				col_villagerD = 1,
				col_augurA = 1,
				col_augurB = 1,
				col_augurAB = 1;

				public string returnText;




	[HideInInspector]
	public CharacterViewController talkChar;

	void Start() {
		talkManager = GameObject.Find("TalkManager").GetComponent<TalkManager>();
		stageManager = GameObject.Find("StageManager").GetComponent<StageManager>();
		charas = GameObject.FindGameObjectsWithTag("Character");
		fpController = GetComponent<FirstPersonController>();
		for(int i=0; i<charas.Length; i++){
			character.Add(new CharacterViewController());
			character[i] = charas[i].GetComponent<CharacterViewController>();

		}
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Return) && talkChar!= null){
			talkChar.talkCameraObj.SetActive(false);
			GetComponent<FirstPersonController>().enabled = true;
		}
	}

	//Characterタグのやつに当たったらカメラを切り替える
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Character"){
			talkChar = other.gameObject.GetComponent<CharacterViewController>();
			talkChar.talkCameraObj.SetActive(true);
			if (talkChar.actRole == 0) {
				//print("はいったよおおおお:actRole1:date="+stageManager.date);
				pushTalk = talkManager.talks_villagerA[stageManager.condition, stageManager.date];
				stageManager.talkVillagerA += 1;
				//print("pushTalkの中身はこれ！："+pushTalk);
			} else if (talkChar.actRole == 1) {
				pushTalk = talkManager.talks_villagerB[stageManager.condition, stageManager.date];
				stageManager.talkVillagerB += 1;
				
			} else if (talkChar.actRole == 2) {
				pushTalk = talkManager.talks_augurB[stageManager.condition, stageManager.date];
				stageManager.talkAugurB += 1;
			}  else if (talkChar.actRole == 3) {
				pushTalk = talkManager.talks_villagerD[stageManager.condition, stageManager.date];
				stageManager.talkVillagerD += 1;
			}  else if (talkChar.actRole == 4) {
				pushTalk = talkManager.talks_augurA[stageManager.condition, stageManager.date];
				stageManager.talkAugurA += 1;
			}  else if (talkChar.actRole == 5) {
				//col_villagerB++;
				pushTalk = talkManager.talks_villagerC[stageManager.condition, stageManager.date];
				stageManager.talkVillagerC += 1;
			} 

			log.Add (pushTalk);

			/*string SplitNewLine(string talk){
				string[] bunkatu = talk.Split(';');
				for(int i=0; i<bunkatu.Length; i++){
				bunkatu += bunkatu[i] + "\n";
				}

				return kaigyou;
			}*/

			//detailNewLine == pushTalkをさらに細かく分割したもの(List)
			//pushTalkをspritで改行
			for(int i=0; i<detailNewLine.Count; i++) {
				if (detailNewLine[i] == "|<kaigyou>|") {
					pushTalk += "\n";
				} else {
					pushTalk += detailNewLine[i];
				}
			}



			print (talkChar.actRole.ToString()+":"+pushTalk);
			talkChar.ShowTalk(pushTalk);
			GetComponent<FirstPersonController>().enabled = false;	
		}
	}

}
