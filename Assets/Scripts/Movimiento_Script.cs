using UnityEngine;
using System.Collections;

public class Movimiento_Script : MonoBehaviour {


	public int vhorizontal = 1;
	public int vvertical = 1;
	Vector3 movimiento;

	// Update is called once per frame
	void Update () {

		if (!GameControl.dead) {
						var v = Input.GetAxis ("Vertical");
						var h = Input.GetAxis ("Horizontal");

						if (h < 0) {
								transform.localScale = new Vector3 (-5, 5,5);
						} else if (h > 0) {
								transform.localScale = new Vector3 (5, 5,5);
						}
		 
						movimiento = new Vector3 (vhorizontal * h, vvertical * v, 0);
						transform.Translate (movimiento * Time.deltaTime);
				}


	
	}
}
