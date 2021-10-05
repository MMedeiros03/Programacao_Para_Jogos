using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {

	// Referência ao projétil para atirar
	public GameObject projetil;
	public float forca = 10.0f;
	
	// Referência ao efeito sonoro de tiro
	public AudioClip shootSFX;
	
	// Update é chamado uma vez por frame
	void Update () {
		// Detecta se o botão de tiro foi pressionado
		if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
		{	
			// se o projetil foi definido
			if (projetil)
			{
				// Instancia o projetil na posição da camera + 1 metro a frente com a rotação da camera
				GameObject newProjectile = Instantiate(projetil, transform.position + transform.forward, transform.rotation) as GameObject;

				// Se o projetil não tiver um Rigidbody, adicione um
				if (!newProjectile.GetComponent<Rigidbody>()) 
				{
					newProjectile.AddComponent<Rigidbody>();
				}

				// Aplique força ao Rigidbody do newProjectile
				newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * forca, ForceMode.VelocityChange);
				
				// toque o efeito sonoro, se houver
				if (shootSFX)
				{
					if (newProjectile.GetComponent<AudioSource> ()) { 
						// se o projetil tiver um componente AudioSource
						// toca o efeito sonoro através deste componente AudioSource.
						// nota: O audio irá viajar com o gameobject.
						newProjectile.GetComponent<AudioSource> ().PlayOneShot (shootSFX);
					} else {
						// dinamicamente cria um novo gameObject com um AudioSource
						// que se auto-destroi quando o audio termina
						AudioSource.PlayClipAtPoint (shootSFX, newProjectile.transform.position);
					}
				}
			}
		}
	}
}
