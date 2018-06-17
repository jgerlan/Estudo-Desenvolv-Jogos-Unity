using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilBehaviourScript : MonoBehaviour {

	public GameObject projetilPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			//atira
			GameObject go = Instantiate(projetilPrefab) as GameObject;
			go.transform.position = this.gameObject.transform.position;
			go.transform.rotation = this.gameObject.transform.rotation;
			go.transform.Translate (Vector3.forward * 1.0f);
			go.GetComponent<Rigidbody> ().AddForce (go.transform.forward * 1000.0f);
		}

	}
}
