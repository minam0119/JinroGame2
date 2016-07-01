using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class foreachTest : MonoBehaviour {
	List<string> testList;
	List<GameObject> testList2 = new List<GameObject>();
	[SerializeField]
	GameObject a, b ,c;

	// Use this for initialization
	void Start () {
		testList = new List<string>();
		testList.Add("い");
		testList.Add("ろ");
		testList.Add("は");
		foreach (string s in testList) {
			print(s.ToString());
		}

		a = Instantiate(Resources.Load("Character/0")) as GameObject;
		b = Instantiate(Resources.Load("Character/1")) as GameObject;
		c = Instantiate(Resources.Load("Character/2")) as GameObject;
		//testList2 = new List<GameObject>();
		testList2.Add(a);
		testList2.Add(b);
		testList2.Add(c);
		foreach (GameObject o in testList2) {
			print(o.ToString());
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
