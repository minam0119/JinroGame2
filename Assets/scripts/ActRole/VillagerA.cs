using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;

public class VillagerA : MonoBehaviour {	//村人A

	StageManager stageManager;
	 public int condition;
	 public const int afterAugurA = 2;
	 public const int afterAugurB = 3;
	 public const int afterAugurAandB = 4;
	 public const int VillagerCthreetime = 9;
	 /* 占い師Aに話しかけた後 == 2
	 	占い師Bに話しかけた後 == 3
	 	占い師AとBに話しかけた後 == 4	*/

	void ChangeColmn(){
		//占い師Aに話しかけたらColmnを2に変更
		if(stageManager.talkVillagerA > 0){
			condition = afterAugurA;
		}
		//占い師Bに話しかけたらColmnを3に変更
		if(stageManager.talkAugurB > 0){
			condition = afterAugurB;
		}
		//占い師ABに話しかけたらColmnを4に変更
		if(stageManager.talkAugurAandB > 0){
			condition = afterAugurAandB;
		}
		
		//村人Cに話しかける && 3回目
		if(stageManager.talkVillagerC == 3){
			condition = VillagerCthreetime;
		}
	}
}
