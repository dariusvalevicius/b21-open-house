using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    // public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;


    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        yRotation = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);

        yRotation += mouseX;
        //yRotation = Mathf.Clamp(yRotation, -90f, -180f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        // transform.localRotation = Quaternion.Euler(xRotation, transform.localEulerAngles.y, 0f);
        // transform.Rotate(Vector3.up * mouseX);


        // Send raycast for interactable objects

        // RaycastHit hit;
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        // if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Interactable") 
        // {
        //     Transform objectHit = hit.transform;
        //     print("Hit");
            
        //     InteractableObject interactable = objectHit.GetComponent<InteractableObject>();
        //     interactable.ChangeColor();
        // }


    }

    private void OnEnable() {
        xRotation = transform.eulerAngles.x;
        yRotation = transform.eulerAngles.y;
    }


}
