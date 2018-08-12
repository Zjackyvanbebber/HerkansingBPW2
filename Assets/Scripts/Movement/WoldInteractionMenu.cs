using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WoldInteractionMenu : MonoBehaviour {
    UnityEngine.AI.NavMeshAgent playerAgent;
    public Animator charAnim;
    public GameObject mark;


     void Start()
    {
        playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteraction();

        if (!playerAgent.pathPending)
        {
            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                if (!playerAgent.hasPath || playerAgent.velocity.sqrMagnitude == 0f)
                {
                    charAnim.SetBool("isWalking", false);
                }
            }
        }
    }

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        RaycastHit hit;
        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
            charAnim.SetBool("isWalking", true);
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

        if (Physics.Raycast(interactionRay, out hit, Mathf.Infinity))
        {
            mark.transform.position = hit.point;
            Instantiate(mark, mark.transform.position, Quaternion.identity);
        }


    }

}
