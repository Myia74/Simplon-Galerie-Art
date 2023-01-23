using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseX;
    [SerializeField] private float mouseY;
    [SerializeField] private float mouseSpeed = 300.0f;
    [SerializeField] private Transform fpsPlayerBody;
    [SerializeField] private float xRotation = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // pour bloquer la rotation de la camera via la souris 
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime; //instanciation souris camera sur X
        mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime; // instanciation souris camera sur Y

        xRotation -= mouseY;  //rotation avec la souris sur axe Y
        xRotation = Mathf.Clamp(xRotation, -90, 90);  
        // va fonctionner avec cursor lock
        /*Mathf.Clamp est une fonction qui permet de limiter la valeur d'une variable à une plage de valeurs spécifiée normalement 3
         * Il prend trois paramètres : la valeur à limiter, la valeur minimale de la plage et la valeur maximale de la plage. 
         * Si la valeur est inférieure à la valeur minimale, la fonction renvoie la valeur minimale. 
         * Si la valeur est supérieure à la valeur maximale, la fonction renvoie la valeur maximale. 
         * Sinon, elle renvoie la valeur telle quelle         * 
         */

        //application de la rotation sur Y
        /*(Quaternion.Euler est une méthode qui permet de convertir un vecteur de rotation en degrés en un quaternion de rotation)
        * Il prend un vecteur de 3 composantes (en x, y et z) qui représente les angles de rotation en degrés sur chacun des axes.
        */

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);


fpsPlayerBody.Rotate(Vector3.up * mouseX);  // rotation avec la souris 

}
}
