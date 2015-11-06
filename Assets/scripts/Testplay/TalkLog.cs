using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;

public class TalkLog : MonoBehaviour {
	TalkManager talkManager;

	// Use this for initialization
	void Start () {
		List<string> talkList = new List<string>(){"ペペロンチーノ","<kaigyou>","ミートスパゲティ","<kaigyou>","イカスミパスタ","<kaigyou>","チーズインハンバーグ"};
		talkList.Add("マルゲリータ");
		List<string[,]> talkList02 = new List<string[,]>();
		string test = "";
		for(int i=0; i<talkList.Count; i++) {
			
			//タグを作成できる
			//改行
			if (talkList[i] == "<kaigyou>") {
				test += "\n";
			} else {
				test += talkList[i];
			}

		}
		print(test);

		//List<string[,]> CSVTest = new List<string[,]>(){csv_villagerA,csv_villagerB,csv_villagerC};
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
