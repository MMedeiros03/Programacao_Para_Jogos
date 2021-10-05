using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {

	// responde em caso de colisão
	void OnCollisionEnter(Collision newCollision)
	{
		// se foi atingido por um projétil...
		if (newCollision.gameObject.tag == "Projetil") {
			// chame a função RestartGame do game manager
			GameManager.gm.RestartGame();
		}
	}
}
