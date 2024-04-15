using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class interactions : MonoBehaviour
{
    public doorSystem doorsystem;
    public soundManager soundManager;
    public float interactDistance = 5f;
    public GameObject playerCamera; 
    public LayerMask interactableLayer; 
    public LayerMask interactableDoor;
    public int whyinteraction;
    bool isPlay = true;

    [SerializeField] private bool isInteracting = false;

    int noInteractions = 0;

    private void Awake()
    {
        
        soundManager = FindObjectOfType<soundManager>();
        soundManager.GetComponent<soundManager>();


    }
    private void Start()
    {
        interactableLayer = LayerMask.GetMask("interactableLayer");
        interactableDoor = LayerMask.GetMask("DoorLayer");
    }

    void Update()
    {
        RaycastHit hit;
        
        

        if (Input.GetButtonDown("Fire1") && !isInteracting)
        {
            
            if (Physics.Raycast(playerCamera.transform.position, transform.TransformDirection(Vector3.forward), out hit, interactDistance, interactableLayer))
            {
                
                interactableObjet interactableobject = hit.collider.GetComponent<interactableObjet>();
                if (interactableobject != null)
                {
                    whyinteraction = interactableobject.objectID;

                    switch (whyinteraction)
                    {
                        case 0:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                            }
                            
                            break;
                        case 1:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                            }
                            break;
                        case 2:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                            }
                            break;
                        case 3:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                            }
                            break;
                        case 4:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                            }
                            break;
                        case 5:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                            }
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                }
            }

            
            if (Physics.Raycast(playerCamera.transform.position, transform.TransformDirection(Vector3.forward), out hit, interactDistance, interactableDoor))
            {
                    hit.collider.transform.GetComponent<doorSystem>().ChangeDoorState1();
              
            }


        }
    }

   
}
