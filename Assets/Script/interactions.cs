using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField] int noInteractions = 0;

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
                                noInteractions++;
                            }
                            
                            break;
                        case 1:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 2:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 3:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 4:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 5:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 6:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 7:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 8:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 9:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 10:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 11:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 12:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 13:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
                            }
                            break;
                        case 14:
                            if (isPlay)
                            {
                                soundManager.InteractionSound();
                                soundManager.InteractionDialoge(whyinteraction);
                                noInteractions++;
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

        if (noInteractions == 4 && !isPlay)
        {
            
            soundManager.InteractionSound();
            soundManager.InteractionDialoge(16);
        }

        if (noInteractions == 7)
        {
            soundManager.InteractionSound();
            soundManager.InteractionDialoge(17);
        }

        if (noInteractions == 10)
        {
            soundManager.InteractionSound();
            soundManager.InteractionDialoge(18);
        }

        if (noInteractions == 13)
        {
            soundManager.InteractionSound();
            soundManager.InteractionDialoge(19);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Andrea"))
        {
            print("Si entro");
            soundManager.InteractionSound();
            soundManager.InteractionDialoge(13);
            noInteractions++;

        }
        if (other.CompareTag("Estudio"))
        {
            soundManager.InteractionSound();
            soundManager.InteractionDialoge(15);
            noInteractions++;

        }
        if (other.CompareTag("Principal"))
        {
            soundManager.InteractionSound();
            soundManager.InteractionDialoge(14);
            noInteractions++;

        }
    }


}
