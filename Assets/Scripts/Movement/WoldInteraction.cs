using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WoldInteraction : MonoBehaviour {
    UnityEngine.AI.NavMeshAgent playerAgent;

     void Start()
    {
        playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteraction();

      

    }

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactedObejct = interactionInfo.collider.gameObject;
            if(interactedObejct.tag == "Interactable Object")
            {
                interactedObejct.GetComponent<Interactable>().MoveToInteraction(playerAgent);
            }
            else
            {
                playerAgent.stoppingDistance = 0;
                playerAgent.destination = interactionInfo.point;
            }
        }
            

    }

}
