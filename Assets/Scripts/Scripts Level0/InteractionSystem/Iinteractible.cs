using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iinteractible 
{
    public string InteractionPromt { get; }

    public bool Interact(Interactor interactor);
}
