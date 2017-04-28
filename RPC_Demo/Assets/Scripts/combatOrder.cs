using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class combatOrder : MonoBehaviour, IHasChanged {
   [SerializeField] Transform fragslots;
   [SerializeField] Transform loopslots;
   [SerializeField] Text combatText;
   Text combatAnimation;
   [SerializeField] Animator anim;
    int c, k=0; 
    public void HasChanged()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        System.Text.StringBuilder animationBuilder = new System.Text.StringBuilder();
       // builder.Append(" ");
       foreach(Transform slotTransform in loopslots){
            
            GameObject loop = slotTransform.GetComponent<slots>().item;
            if (loop)
            {
                k = c;
            }
        }
        foreach(Transform slotTransform in fragslots)
        {
            GameObject function = slotTransform.GetComponent<slots>().item;
            if(function)
            {
                animationBuilder.Append(function.name);
                builder.Append(function.name);
                builder.Append("-> ");
            }
        }
        //combatAnimation.text = animationBuilder.ToString();
        combatText.text = builder.ToString();

    }

   public void Fight()
    {
        // anim = GetComponent<Animator>();

        anim.SetTrigger("doneAction");
        anim.SetTrigger("fwd");
        anim.SetTrigger("doneAction");
        anim.SetTrigger("atk");
        anim.SetTrigger("doneAction");

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

