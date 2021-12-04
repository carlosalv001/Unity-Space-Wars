using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLimits : MonoBehaviour
{

    private Transform theTransform = null;
    public Vector2 horizontalRange = Vector2.zero;
    public Vector2 vertialRange = Vector2.zero;



    private void Awake()
    {
        theTransform = GetComponent<Transform>();   
    }

    //Se llama una vez por frame y se actualiza despues del update 
    private void LateUpdate()
    {
        theTransform.position = new Vector3(Mathf.Clamp(theTransform.position.x, horizontalRange.x, horizontalRange.y),
                                            Mathf.Clamp(theTransform.position.y, 0, 0),
                                            Mathf.Clamp(theTransform.position.z, vertialRange.x, vertialRange.y));   
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
