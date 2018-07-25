using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	//Variable global para definir la velocidad
	public float forceValue;
	//Variable para la fuerza utilizando Rigidbody
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		//Para optimizar el rendimiento se inicializa en Start
		// y se almacena la componente en la variable creada
		//se evita la sobrecarga de llamar getcomponente en FixedUpdate
		//GetComponente se puede acceder a componentes de gameobject
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	// Se ejecuta por defecto 50 veces por segundo
	//Codigo que se sincroniza con el motor fisico 
	// En este caso se empuja se aplica una fuerza constante 
	//a la esfera con las teclas del cursor
	void FixedUpdate () {
		//Metodo AddForce añade una fuerza a la componente Rigidbody del gameobject
		//Genera fuerza de emuje para que ruede
		//Vector3 es de tres componentes
		rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
			0,
			Input.GetAxis("Vertical")) * forceValue);


	}
}
