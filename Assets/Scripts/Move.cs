using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Transform theTransform = null;
    public float maxSpeed = 8.0f;
    private void Awake()
    {
        theTransform = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theTransform.position += theTransform.forward * maxSpeed * Time.deltaTime;
    }
}
