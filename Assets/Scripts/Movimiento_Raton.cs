using UnityEngine;
using System.Collections;

public class Movimiento_Raton : MonoBehaviour {
	Vector3 posicionRaton;
	public int velocidad = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		posicionRaton = Input.mousePosition;
		
		posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton);
		
		if (Input.GetMouseButton (0)) {
			transform.position = Vector2.Lerp (transform.position, posicionRaton, velocidad*0.01f);

	
	}
}
}