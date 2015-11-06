using UnityEngine;
using System.Collections;

public class VillagerC : MonoBehaviour {	//村人C

	StageManager stageManager;
	 public const int afterAugurA = 2;
	 public const int afterAugurB = 3;
	 public const int afterAugurAandB = 4;
	 public const int afterAugurAandBVillagerA = 7;
	 /* 占い師Aに話しかけた後 == 2
	 	占い師Bに話しかけた後 == 3
	 	占い師AとBに話しかけた後 == 4	
	 	2回目に話しかけたとき == 5
	 	3回目に話しかけたとき == 6
	 	占い師Aと占い師Bと村人Aに話しかけた後 == 7*/

	 	void ChangeColmn(){
	 		if(stageManager.talkAugurA > 0){
	 			stageManager.condition = afterAugurA;
	 		}
	 		if(stageManager.talkAugurB > 0){
	 			stageManager.condition = afterAugurB;
	 		}
	 		if(stageManager.talkAugurAandB > 0){
	 			stageManager.condition = afterAugurAandB;
	 		}
	 		if(stageManager.talkAugurAandAugurBandVillagerA > 0){
	 			stageManager.condition = afterAugurAandBVillagerA;
	 		}
	 		
	 	}
}
