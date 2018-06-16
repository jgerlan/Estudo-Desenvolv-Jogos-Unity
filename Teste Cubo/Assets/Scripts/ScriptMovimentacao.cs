using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovimentacao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.position = this.gameObject.transform.position + Vector3.right*0.1f;
		}else if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.position = this.gameObject.transform.position + Vector3.left*0.1f;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.gameObject.transform.position = this.gameObject.transform.position + Vector3.forward*0.1f;
		}else if (Input.GetKey (KeyCode.DownArrow)) {
			this.gameObject.transform.position = this.gameObject.transform.position + Vector3.back*0.1f;
		}
	}
}
