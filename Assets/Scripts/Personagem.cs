using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

	//vira em uma propriedade do objeto na ide
	public float velocidade;

	// Use this for initialization
	void Start () {

		// Repositiona o sprite para a coordenada especificada
		//transform.position = new Vector2 (-10.0f, 0.0f);

	}

	// Update is called once per frame
	void Update () {

		//movimento um objeto na tela
		//transform.Translate(5.0f * Time.deltaTime, 0.0f, 0.0f);
		//transform.Translate(Vector2.up * 5.0f * Time.deltaTime);

		//tem que ser em 3d por casa do z
		//por frame e não por ciclos (Time.deltaTime)
		//transform.Rotate (Vector3.back * velocidade * Time.deltaTime);

		//pegar os direcionais
		//print(Input.GetAxis("Horizontal"));

		//GetAxis retorna float

		float move_x = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (move_x, 0.0f, 0.0f);

		//Input com retorno booleano
		if(Input.GetButtonDown("Jump")) {
			transform.position = Vector2.zero;
		}



	}
}
