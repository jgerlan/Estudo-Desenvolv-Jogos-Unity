using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarScript : MonoBehaviour {

	public void voltarMenuPrincipal(){
		SceneManager.LoadScene ("Menu");
	}

	public void irCreditos() {
		SceneManager.LoadScene ("Créditos");
	}
}
