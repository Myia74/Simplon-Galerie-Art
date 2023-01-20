using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsPlayerController : MonoBehaviour
{
    private float positionX;
    private float positionZ;

    [SerializeField] private CharacterController controller;
    [SerializeField] private float speedPlayer = 14.0f;

   

    // Update is called once per frame
    void Update()
    {
        positionX = Input.GetAxis("Horizontal");
        positionZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * positionX + transform.forward * positionZ;

        controller.Move(move * speedPlayer * Time.deltaTime);

    }
}
