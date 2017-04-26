using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class combatOrder : MonoBehaviour, IHasChanged {
   [SerializeField] Transform fragslots;
   [SerializeField] Text combatText;
   [SerializeField] Text combatAnimation;
   [SerializeField] Animator anim;
    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
      //  System.Text.StringBuilder animationBuilder = new System.Text.StringBuilder();
       // builder.Append(" ");
        foreach(Transform slotTransform in fragslots)
        {
            GameObject item = slotTransform.GetComponent<slots>().item;
            if(item)
            {
        //        animationBuilder.Append(item.name);
                builder.Append(item.name);
                builder.Append(" -> ");
            }
        }
        //combatAnimation.text = animationBuilder.ToString();
        combatText.text = builder.ToString();

    }

   public void Fight()
    {
       // anim = GetComponent<Animator>();

        anim.SetTrigger("atk");
        anim.SetBool("doneAction", true);
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

