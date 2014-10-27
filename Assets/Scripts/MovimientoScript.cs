using UnityEngine;
using System.Collections;

public class MovimientoScript : MonoBehaviour {

	public int vhorizontal = 10;
	public int vvertical = 10;

	Vector3 movimiento;
	Vector3 posicionRaton;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Lineas par mover con teclado o joystick
		var v = Input.GetAxis ("Vertical");
		var h = Input.GetAxis ("Horizontal");
		movimiento = new Vector3 (vhorizontal * h, vvertical * v, 0);
		transform.Translate (movimiento *Time.deltaTime);

		//Player sigue el movimiento del raton
		//posicionRaton = Input.mousePosition;
		//posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton);

		//transform.position = Vector2.Lerp (transform.position,
		                                   //posicionRaton,
		                                   //vvertical); 
		//if (Input.GetMouseButton (0)) {
				//transform.position = Vector2.Lerp (transform.position,
			                                   //posicionRaton,
			                                   //vvertical*0.01f);
		}		

	
	}

