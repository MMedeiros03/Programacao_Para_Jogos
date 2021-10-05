using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float gravidade = 9.8f;
    private CharacterController meucontrole;

    // Start is called before the first frame update
    void Start()
    {
        meucontrole = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // movimento em z
            Vector3 movimentoz = Input.GetAxis("Vertical") * Vector3.forward * velocidade * Time.deltaTime;
        // movimento em x      
            Vector3 movimentox = Input.GetAxis("Horizontal") * Vector3.right * velocidade * Time.deltaTime;  
        // movimento diagonal
            Vector3 movimento = transform.TransformDirection(movimentoz + movimentox);
        // movimento y
            movimento.y -= gravidade * Time.deltaTime;
        
        meucontrole.Move(movimento);
    }
}
