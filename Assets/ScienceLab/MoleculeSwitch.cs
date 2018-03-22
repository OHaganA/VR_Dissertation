using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.UnityEventHelper;

public class MoleculeSwitch : MonoBehaviour {

    private VRTK_Button_UnityEvents buttonEvents;

    public GameObject[] molecule;
    public TooltipManager tooltip_manager;

    int moleculeIndex = 0;
    string buttonName;

    private void Start()
    {
        buttonEvents = GetComponent<VRTK_Button_UnityEvents>();
        if (buttonEvents == null)
        {
            buttonEvents = gameObject.AddComponent<VRTK_Button_UnityEvents>();
        }
        buttonEvents.OnPushed.AddListener(handlePush);
        buttonName = this.gameObject.name;
    }

    private void handlePush(object sender, Control3DEventArgs e)
    {
        if(buttonName == "LeftButton")
        {
            moleculeIndex -= 1;
        }
        else
        {
            moleculeIndex += 1;
        }

        if (moleculeIndex >= molecule.Length)
        {
            moleculeIndex = 0;
        }

        else if(moleculeIndex < 0)
        {
            moleculeIndex = molecule.Length - 1;
        }
        VRTK_Logger.Info(moleculeIndex.ToString() + " = molecule index");
        for(int i = 0; i < molecule.Length; i++)
        {
            molecule[i].SetActive(false);
        }
        molecule[moleculeIndex].gameObject.SetActive(true);
        tooltip_manager.setMoleculeIndex(moleculeIndex);
    }
}
