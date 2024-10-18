using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    private InputAction movementAction;
    private Actions actions;
    [SerializeField] public Camera cam;
    private float zoomies = 35.7;

 //   [SerializeField] private float moveSpeed = 10;
    
    // Start is called before the first frame update
    void Awake() 
    {
        actions = new Actions();
        movementAction = actions.camera.zoom;
    }

    void OnEnable()
    {
        movementAction.Enable();
    }

    void OnDisable()
    {
        movementAction.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cam.Projection == Perspective)
        {
            cam.fieldOfView = movementAction.ReadValue<Value>() + 35.7;
        }
    }
}
