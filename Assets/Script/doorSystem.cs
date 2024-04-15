using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSystem : MonoBehaviour
{
    public bool openDoor = false;
    public float openDoorAngle = 75f;
    public float closeDoorAngle = 0f;
    public float smooth = 3.0f;

    public soundManager soundManager;





    public void ChangeDoorState()
    {
        openDoor = !openDoor;
        //soundManager.Doors();
    }


    void Update()
    {
        if (openDoor)
        {
            Quaternion targetRotation = Quaternion.Euler(0, openDoorAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(0, 0, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }


    }

}
