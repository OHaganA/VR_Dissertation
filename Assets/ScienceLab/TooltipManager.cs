using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TooltipManager : MonoBehaviour {

    public VRTK_ObjectTooltip tooltip_1;
    public VRTK_ObjectTooltip tooltip_2;

    int moleculeIndex = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        textUpdater(moleculeIndex);
	}

    public void setMoleculeIndex(int index)
    {
        moleculeIndex = index;
    }

    void textUpdater(int moleculeIndex)
    {
        switch (moleculeIndex)
        {
            case 0:
                tooltip_1.UpdateText("Ethanol");
                tooltip_2.UpdateText("Ethanol");
                break;
            case 1:
                tooltip_1.UpdateText("Water");
                tooltip_2.UpdateText("Water");
                break;
        }
    }
}
