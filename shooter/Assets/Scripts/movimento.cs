using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public float velocidade = 0.03f; 
    private bool emx;
    private bool emy;
    private bool emz;

    // Start is called before the first frame update
    void Start()
    {
        emx = (Random.value > 0.2f);
        emy = (Random.value > 0.2f);
        emz = (Random.value > 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(emx){
            gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * velocidade, Space.World);
        }
        if(emy){
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * velocidade, Space.World);
        }
        if(emz){
            gameObject.transform.Translate(Vector3.back * Mathf.Cos(Time.timeSinceLevelLoad) * velocidade, Space.World);
        }
        
    }
}
