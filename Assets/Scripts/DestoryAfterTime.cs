using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryAfterTime : MonoBehaviour
{
    public float destroyTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", destroyTime); //Manda a llamar la funcion Die despues del tiempo establecido

    }

    void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
