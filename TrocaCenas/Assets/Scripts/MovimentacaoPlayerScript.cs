﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.RightArrow)){
			this.transform.Rotate (Vector3.up * 0.5f);
		} else if(Input.GetKey (KeyCode.LeftArrow)){
			this.transform.Rotate (Vector3.up * -0.5f);
		}
	}
}
