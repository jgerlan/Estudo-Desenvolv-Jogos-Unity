using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.gameObject.transform.Translate	(Vector3.forward * 0.1f);
		} else if(Input.GetKey (KeyCode.DownArrow)) {
			this.gameObject.transform.Translate (Vector3.forward* -0.1f);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.Rotate (Vector3.up * 1f);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.Rotate( Vector3.up * -1f);
		}


//		if (Input.GetKey (KeyCode.UpArrow)) {
//			this.gameObject.transform.Translate 
//			(this.gameObject.transform.worldToLocalMatrix.MultiplyVector(this.gameObject.transform.forward) * 0.1f);
//		} else if (Input.GetKey (KeyCode.DownArrow)) {
//			this.gameObject.transform.Translate 
//			(this.gameObject.transform.worldToLocalMatrix.MultiplyVector(this.gameObject.transform.forward) * -0.1f);
//		}
//
//		if (Input.GetKey (KeyCode.RightArrow)) {
//			this.gameObject.transform.Translate 
//			(this.gameObject.transform.worldToLocalMatrix.MultiplyVector(this.gameObject.transform.right) * 0.1f);
//		}else if (Input.GetKey (KeyCode.LeftArrow)) {
//			this.gameObject.transform.Translate 
//			(this.gameObject.transform.worldToLocalMatrix.MultiplyVector(this.gameObject.transform.right) * -0.1f);
//		}

	}
}
