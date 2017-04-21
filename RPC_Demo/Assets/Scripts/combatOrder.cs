using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class combatOrder : MonoBehaviour, IHasChanged {
    [SerializeField] Transform slots;


    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" -> ");
        foreach(Transform slotTransform in slots)
        {
          //  GameObject item = slotTransform.GetComponent<Slot>().item;
        }

    }

    // Use this for initialization
    void Start() {
        HasChanged();
    }
}


namespace UnityEngine.EventSystems
{
    public interface IHasChanged : IEventSystemHandler
    {
        void HasChanged();
    }
}

