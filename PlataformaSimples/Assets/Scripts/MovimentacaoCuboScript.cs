using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoCuboScript : MonoBehaviour {

	float velocidade;
	float forcaPulo;
	bool possoPular;

	// Use this for initialization
	void Start () {
		velocidade = 0.1f;
		forcaPulo = 300.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightArrow)) {
			this.gameObject.transform.Translate (Vector3.right * velocidade);
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			this.gameObject.transform.Translate (Vector3.right * -velocidade);
		}

		if (Input.GetKeyDown(KeyCode.Space) && possoPular) {
			this.gameObject.GetComponent<Rigidbody>().AddForce (Vector3.up * forcaPulo);
		}

	}

	void OnCollisionStay(Collision col) {
		if (col.gameObject.tag.Equals ("plataforma") || col.gameObject.tag.Equals ("chao")) {
			//Debug.Log ("Colisao");
			possoPular = true;
		}
	}

	void OnCollisionExit(Collision col) {
		if (col.gameObject.tag.Equals ("plataforma") || col.gameObject.tag.Equals ("chao")) {
			//Debug.Log ("Colisao");
			possoPular = false;
		}
	}
}
