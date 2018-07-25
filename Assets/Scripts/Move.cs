using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	//Variable global para definir la velocidad
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	//transform tiene la posiscion, rotacion y escala
	//para cambiar la posicion se utiliza el metodo translate
	//Para controlar movimiento se gestiona con Input (teclas,
		// acelerometro gamepad, etc)
	//GetAxis("Horizontal") puede mover con las teclas o en 
		//gamepad izquierda o derecha valores (-1 o 1)
		//Time.deltaTime para poder especificar en metros

	transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 
		0, 
		Input.GetAxis("Vertical") * speed * Time.deltaTime);

	}
}
