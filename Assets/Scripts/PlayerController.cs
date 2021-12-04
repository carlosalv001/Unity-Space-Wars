using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody theBody = null;
    private Transform theTransform = null;

    public bool mouseLook = true;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public string fireAxis = "Fire";
     
    public float maxSpeed = 4.0f;

    //Se ejecuta antes del start 
    private void Awake()
    {
        theBody = GetComponent<Rigidbody>();
        theTransform = GetComponent<Transform>();
    }

    //Es un update pero para las fisicas
    private void FixedUpdate()
    {
        //Actualizar el movimiento
        float horizontal = Input.GetAxis(horizontalAxis); //valor entre 1 y -1 
        float vertical = Input.GetAxis(verticalAxis);

        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);
        theBody.AddForce(direction.normalized * maxSpeed);

        //Actualizar la velociadad
        theBody.velocity = new Vector3(Mathf.Clamp(theBody.velocity.x, -maxSpeed, maxSpeed), //El Clamp nó permite que se pase de maxSpeed y se se pasa regresa el maxSpeed
                                       Mathf.Clamp(theBody.velocity.y , -maxSpeed , maxSpeed),
                                       Mathf.Clamp(theBody.velocity.z, -maxSpeed, maxSpeed));

        //Rotacion de la nave con raton 
        if (mouseLook)
        {
            Vector3 mousePositionInScreen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0); // coordenadas del mouse 
            Vector3 mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionInScreen);
            mousePositionInWorld = new Vector3(mousePositionInWorld.x, 0.0f, mousePositionInWorld.z);

            Vector3 positionToLook = mousePositionInWorld - theTransform.position;
            theTransform.localRotation = Quaternion.LookRotation(positionToLook.normalized, Vector3.up);

        }

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
