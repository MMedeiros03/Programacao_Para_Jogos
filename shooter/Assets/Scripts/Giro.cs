using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public float velocidade = 180.0f;
    private bool emx = false;
    private bool emy = false;

    // Start is called before the first frame update
    void Start()
    {
        emx = (Random.value > 0.2f);
        emy = (Random.value > 0.2f); 
    }

    // Update is called once per frame
    void Update()
    {
        if(emy){
            gameObject.transform.Rotate(Vector3.up * velocidade * Time.deltaTime,Space.World);
        }
        if(emx){
            gameObject.transform.Rotate(Vector3.right * velocidade * Time.deltaTime,Space.World);
        }
      
    }
}
