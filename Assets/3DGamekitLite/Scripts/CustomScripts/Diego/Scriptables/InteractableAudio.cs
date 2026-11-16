using System;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;


[CreateAssetMenu(fileName = "InteractableAudio", menuName = "Scriptable Objects/InteractableAudio")]
public class InteractableAudio : ScriptableObject
{
    [SerializeField] private EventReference pickUpHealth, boxDestroy;


    public void PickupHealthPlay(GameObject m)
    {
        RuntimeManager.PlayOneShotAttached(pickUpHealth, m);
    }
    
    public void BoxDestroyPlay(GameObject m)
    {
        RuntimeManager.PlayOneShotAttached(boxDestroy, m);
    }
    
}

