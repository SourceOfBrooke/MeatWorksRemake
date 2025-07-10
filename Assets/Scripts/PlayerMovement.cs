using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    public CameraMovement playerCamera;
    public float walkSpeed;
    GameObject player;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player =  GetComponent<GameObject>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // rotate the dang player model on the Y axis!!
        rb.transform.rotation = Quaternion.Euler(0, playerCamera.yRotation, 0);
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(transform.forward * walkSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -walkSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * walkSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -walkSpeed * Time.deltaTime, Space.World);
        }

    }

    

   
}
