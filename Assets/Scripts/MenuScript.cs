using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	Animator animacion_panel;
	// Use this for initialization
	void Start () {
		animacion_panel = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	if (GameControl.dead) {
			animacion_panel.SetBool ("MuestraMenu", true);
	}
  }


public void restart(){

	animacion_panel.SetBool ("MuestraMenu", false);
	Application.LoadLevel (Application.loadedLevel);
}

public void quit(){

	Application.Quit ();

  }
}