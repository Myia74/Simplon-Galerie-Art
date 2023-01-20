using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseX;
    [SerializeField] private float mouseY;
    [SerializeField] private float mouseSpeed = 100.0f;
    [SerializeField] private Transform fpsPlayerBody;
    [SerializeField] private float xRotation = 0.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime; //instanciation souris camera sur X
        mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime; // instanciation souris camera sur Y

        xRotation -= mouseY;  //rotation avec la souris sur axe Y

        //application de la rotation sur Y  (Quaternion.Euler est une méthode qui permet de convertir un vecteur de rotation en degrés en un quaternion de rotation)
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);


        fpsPlayerBody.Rotate(Vector3.up * mouseX);  // rotation avec la souris 

    }
}
