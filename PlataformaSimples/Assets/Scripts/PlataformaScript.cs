using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaScript : MonoBehaviour {

	float tempo;

	// Use this for initialization
	void Start () {
		tempo = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		//float i;
		if (Time.time - tempo > 2.0f){
			for(float i=0.0f; i<8.0f; i++){
				Debug.Log (i);
				this.gameObject.transform.position = new Vector3 (i, 3.0f, -4.0f);
			}
		}
	}
}
