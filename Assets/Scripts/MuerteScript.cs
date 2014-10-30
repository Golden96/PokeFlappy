using UnityEngine;
using System.Collections;

public class MuerteScript : MonoBehaviour {
	public static bool dead = false;

	
	// Update is called once per frame
	void Update () {
	
	}


 void	OnCollisionEnter2D(Collision2D col){


		if (col.transform.tag == "Player") {
			GameControl.dead = true;
				}
					


	}
  


 












}
