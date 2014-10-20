using UnityEngine;
using System.Collections;

public class GeneradoScript : MonoBehaviour {

	public GameObject torre;
	public float tiempoespera = 3;
	Vector3 posicion;
	float timer = 0;
	// Use this for initialization
	void Start () {
		posicion = transform.position;
   }
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > timer) {
			var altura = Random.Range(-1.5f,1.5f);





			var nuevatorre = (GameObject)Instantiate(
				torre,
				new Vector3(posicion.x,posicion.y+altura,0),
				transform.rotation);

			Destroy(nuevatorre,tiempoespera*3);

			timer = Time.time+tiempoespera;
	  }
   }
}