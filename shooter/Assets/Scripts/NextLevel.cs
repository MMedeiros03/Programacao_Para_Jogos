using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	// responde nas colisões
	void OnCollisionEnter(Collision newCollision)
	{
		// se atingido por um projétil...
		if (newCollision.gameObject.tag == "Projetil") {
			// Chame a função NextLevel no game manager
			GameManager.gm.NextLevel();
		}
	}
}
