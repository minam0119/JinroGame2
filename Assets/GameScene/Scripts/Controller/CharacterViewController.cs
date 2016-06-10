using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterViewController : MonoBehaviour {
	
	public Camera characterCamera;
	[SerializeField]
	public CharacterData data = new CharacterData();
	public CharacterTalkView talkView;
	public Transform avatar;

	//キャラクターオブジェクトの見た目をavatarIdに適当させる
	/*public void SetCharacter (string[] d) {
		data.SetCharaData(d);
		GameObject obj = Instantiate(Resources.Load("Avatar/" 
			+ data.avatarId.ToString())) as GameObject;
		avatar = obj.transform;
		avatar.SetParent(this.transform);
		avatar.localPosition = Vector3.zero;
	}*/

	//キャラクターオブジェクトに当たったらカメラを切り替える
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			//int num = int.Parse(other.gameObject.name.Substring(0,1));
			characterCamera.enabled = true;
		}
	}

	//キャラクターオブジェクトから離れたらカメラを切り替える
	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
			//int num = int.Parse(other.gameObject.name.Substring(0,1));
			characterCamera.enabled = false;
		}
	}

}
