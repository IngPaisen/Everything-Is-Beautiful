using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class camera : MonoBehaviour
{


    public float lookSensitivity = 80f;
    float xRotation;

    public Transform player;


    public Transform headerTransform;
    public Transform cameraTransform;

    public float bobFrequency = 5f;
    public float bobHorAmplitude = 0.1f;
    public float bobVertAmplitude = 0.1f;
    [Range(0, 1)] public float headBobSmoothing = 0.1f;

    public bool isWalking;
    private float walkingTime;
    private Vector3 targetCamerapos;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    { //actualiza los valores en el eje X
        float mouseX = Input.GetAxisRaw("Mouse X") * lookSensitivity * Time.deltaTime;
        player.Rotate(Vector3.up * mouseX);

        //actualiza los valores en el eje Y
        float mouseY = Input.GetAxisRaw("Mouse Y") * lookSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70, 70);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);


        if (!isWalking)
        {
            walkingTime = 0;
        }
        else
        {
            walkingTime += Time.deltaTime;
        }


        targetCamerapos = headerTransform.position + CalculateHeadBobOffset(walkingTime);

        cameraTransform.position = Vector3.Lerp(cameraTransform.position, targetCamerapos, headBobSmoothing);
        if ((cameraTransform.position - targetCamerapos).magnitude <= 0.001)
        {
            cameraTransform.position = targetCamerapos;
        }


    }

    private Vector3 CalculateHeadBobOffset(float t)
    {
        float horOffset = 0;
        float verOffset = 0;

        Vector3 offset = Vector3.zero;
        if (t > 0)
        {
            horOffset = Mathf.Cos(t * bobFrequency) * bobHorAmplitude;
            verOffset = Mathf.Sin(t * bobFrequency * 2) * bobVertAmplitude;
        }

        offset = headerTransform.right * horOffset + headerTransform.up * verOffset;

        return offset;
    }
}
