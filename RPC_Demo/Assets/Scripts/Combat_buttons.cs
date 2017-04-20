using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_buttons : MonoBehaviour {

    public Transform panelMove;
    public Transform panelGear;
    public Transform panelCombat;
    public Transform panelTactics;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void hideMove()
    {

        panelCombat.gameObject.SetActive(false);
        panelGear.gameObject.SetActive(false);
        panelTactics.gameObject.SetActive(false);

    }
    public void hideGear()
    {

        panelMove.gameObject.SetActive(false);
        panelCombat.gameObject.SetActive(false);
        panelTactics.gameObject.SetActive(false);

    }
    public void hideCombat()
    {

        panelMove.gameObject.SetActive(false);
        panelGear.gameObject.SetActive(false);
        panelTactics.gameObject.SetActive(false);

    }
    public void hideTactics()
    {
        panelMove.gameObject.SetActive(false);
        panelGear.gameObject.SetActive(false);
        panelCombat.gameObject.SetActive(false);

    }
    public void showMove()
    {
        panelMove.gameObject.SetActive(true);

    }

    public void showGear()
    {

        panelGear.gameObject.SetActive(true);

    }

    public void showCombat()
    {
        panelCombat.gameObject.SetActive(true);
    }

    public void showTactics()
    {

        panelTactics.gameObject.SetActive(true);

    }

}
