using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Perfect : MonoBehaviour, Iinteractible
{
    [SerializeField] private string promt;
    [SerializeField] private Animator animator;
    public string InteractionPromt => promt;

    public bool Interact(Interactor interactor)
    {
        //Debug.Log("plant!");
        animator.SetBool("grow", true);
        return true;
    }
}
