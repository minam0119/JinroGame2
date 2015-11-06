using UnityEngine;
using System.Collections;

public class VillagerB : MonoBehaviour {	//村人B
	StageManager stageManager;
	 public const int afterAugurA = 2;
	 public const int afterAugurB = 3;
	 public const int afterAugurAandB = 4;
	 public const int threetime = 4;
	 public const int afterAugurAandBVillagerD = 8;
	 /* 占い師Aに話しかけた後 == 2
	 	占い師Bに話しかけた後 == 3
	 	占い師AとBに話しかけた後 == 4
	 	3回目(3回以上)話しかけたとき == 6
	 	占い師A,占い師B,村人Dに話しかけた後 == 8	*/

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
	 		if(stageManager.talkVillagerB >= 3){
	 			stageManager.condition = threetime;
	 		}
	 		if(stageManager.talkAugurAandBandVillagerD > 0){
	 			stageManager.condition = afterAugurAandBVillagerD;
	 		}
	 	}
}
