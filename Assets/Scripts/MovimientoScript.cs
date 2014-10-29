using UnityEngine;
using System.Collections;

public class MovimientoScript : MonoBehaviour {

	public int vhorizontal = 10;
	public int vvertical = 10;

	Vector3 movimiento;
	Vector3 posicionRaton;

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.dead == false) {

						//Lineas par mover con teclado o joystick
						var v = Input.GetAxis ("Vertical");
						var h = Input.GetAxis ("Horizontal");
						movimiento = new Vector3 (vhorizontal * h, vvertical * v, 0);
						transform.Translate (movimiento * Time.deltaTime);
				}

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

		void OnCollisionEnter2D(Collision2D coll){

			if (coll.gameObject.tag == "Enemy")
				GameControl.score = GameControl.score -1;
			
			if (coll.gameObject.tag == "Points")
				GameControl.score = GameControl.score +1;

			if (coll.gameObject.tag == "Win")
				Application.LoadLevel(Application.loadedLevel);

			if (coll.gameObject.tag == "Enemy" && GameControl.score == 0)
				GameControl.dead = true;
				anim.SetBool("Muerte",true);
				Application.LoadLevel(Application.loadedLevel);
			
			}		

	}


