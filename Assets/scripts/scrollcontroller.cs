﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scrollcontroller : MonoBehaviour {

	[SerializeField]
	RectTransform prefab = null;
 
	void Start () 
	{
		for(int i=0; i<15; i++)
		{
			var item = GameObject.Instantiate(prefab) as RectTransform;
			item.SetParent(transform, false);
 
			var text = item.GetComponentInChildren<Text>();
			text.text = "item:" + i.ToString();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
