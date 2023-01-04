using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private float interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask interactableMask;
    [SerializeField] private InteractionPromtUI interactionPromtUI;

    private readonly Collider[] colliders = new Collider[1];
    [SerializeField] private int numFound;

    private Iinteractible interactable;

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(interactionPoint.position, interactionPointRadius, colliders, interactableMask);
        //als hij een inteacteble vind
        if(numFound > 0)
        {
            interactable = colliders[0].GetComponent<Iinteractible>();

            if (interactable != null)
            {
                if (!interactionPromtUI.IsDisplayed) 
                {
                    interactionPromtUI.SetUp(interactable.InteractionPromt);
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact(this);
                }
            }
        }
        else
        {
            if (interactable != null)
            {
                interactable = null;
            }
            if(interactionPromtUI.IsDisplayed)
            {
                interactionPromtUI.Close();
            }
        }
    }

    //for debug
    /*private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(interactionPoint.position, interactionPointRadius);
    }*/
}
