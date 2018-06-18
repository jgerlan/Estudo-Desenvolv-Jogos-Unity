using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoScript : MonoBehaviour {

	public GameObject cuboInimigo;

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
	}

	void OnCollisionEnter(Collision col) {
		Debug.Log("bateu");
	}

	void OnTriggerEnter(Collider col) {
		Debug.Log("encostou");
		// Mudar Cor
		GameObject game = GameObject.FindGameObjectWithTag("inimigo");
		cuboInimigo.GetComponent<Renderer> ().material.color = Color.yellow;
	}

	void OnTriggerExit(Collider col){
		Debug.Log ("desencostou");
		// Mudar Cor
		GameObject game = GameObject.FindGameObjectWithTag("inimigo");
		cuboInimigo.GetComponent<Renderer> ().material.color = Color.red;
	}

}
