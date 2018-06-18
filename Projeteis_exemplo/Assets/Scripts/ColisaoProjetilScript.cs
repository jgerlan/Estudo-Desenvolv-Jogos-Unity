using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoProjetilScript : MonoBehaviour {

	float tempo;

	// Use this for initialization
	void Start () {
		tempo = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - tempo > 5.0f) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision col){
		Debug.Log("Colisao");
		if (col.gameObject.tag.Equals("inimigo")){
			//col.gameObject.transform.position = new Vector3 (Random.Range(-3.0f, 3.0f), 0.5f, Random.Range (-3.0f, 3.0f));
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
	}
}
