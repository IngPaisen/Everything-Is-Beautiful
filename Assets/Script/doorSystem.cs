using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSystem : MonoBehaviour
{
    public bool openDoor = false;
    public bool openDoor2 = false;
    public float openDoorAngle = 90f;
    public float openDoorAngle2 = -160f;
    public float closeDoorAngle = 0f;
    public float smooth = 3.0f;

    public soundManager soundManager;





    public void ChangeDoorState1()
    {
        openDoor = !openDoor;
        //soundManager.Doors();
    }

    public void ChangeDoorState2()
    {
        openDoor2 = !openDoor2;
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

        if (openDoor2)
        {
            Quaternion targetRotation = Quaternion.Euler(0, openDoorAngle2, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(0, 0, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }


    }

}
