﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlySpawner : MonoBehaviour {

	public GameObject MinionPrefab;
	private GameObject Minion;
	private int instanceState = 0;
	private Vector3 mousePos;
	private Minion MinionScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(instanceState == 1){
			mousePos = Input.mousePosition;
			mousePos.z = 10f;
			Minion.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
			if( MinionScript.isClicked == true )
				instanceState = 0;
		}
	}

	void OnMouseDown(){
		if(instanceState == 0){
			Minion = Instantiate(MinionPrefab);
			MinionScript = Minion.GetComponent<Minion>();
			instanceState = 1;
		}
	}

}
