using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public Transform objectToFollow = null; // a quien seva a seguir y se hace public para poder ponerlo desde Unity 
    public bool followPlayer = false;
    private Transform theTransform = null;


    private void Awake()
    {
        theTransform = GetComponent<Transform>();
        if (!followPlayer)
        {
            return;
        }
        else
        {
            GameObject thePlayer = GameObject.FindGameObjectWithTag("Player");
            if(thePlayer != null)
            {
                objectToFollow = thePlayer.GetComponent<Transform>();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFollow == null)
            return;
        Vector3 directionToFollow = objectToFollow.position - theTransform.position;
        if(directionToFollow != Vector3.zero)
        {
            theTransform.localRotation = Quaternion.LookRotation(directionToFollow.normalized, Vector3.up); //hace que se gire automaticamente a donde esta el player 
        }
    }
}
