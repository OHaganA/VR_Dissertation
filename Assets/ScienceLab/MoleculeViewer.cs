using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeViewer : MonoBehaviour {
    private Transform molecule;

	// Use this for initialization

	void Start () {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (gameObject.transform.GetChild(i).gameObject.activeSelf == true)
            {
               molecule = gameObject.transform.GetChild(i);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (gameObject.transform.GetChild(i).gameObject.activeSelf == true)
            {
                molecule = gameObject.transform.GetChild(i);
            }
        }
        molecule.Rotate(Vector3.up * Time.deltaTime * 10);
	}
}
