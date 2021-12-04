using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{

    public GameObject deathParticlesPrefab = null;
    private Transform theTransform = null;
    public bool shouldBeDestroyed = true;
    public float healthPoints
    {
        get
        {
            return _healthPoints;
        }

        set
        {
             _healthPoints = value;
            if(healthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);  //Manda un evento pero solo se debe de usar para cosas puntuales 

                if(deathParticlesPrefab != null)
                {
                    Instantiate(deathParticlesPrefab, theTransform.position, theTransform.rotation);//Pone la animacion de muerte donde fue el objeto 
                    if (shouldBeDestroyed)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        theTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    [SerializeField] //esto permite que se pueda ver desde el editor como si fuera publica pero es privada
    private float _healthPoints = 100.0f;

}
