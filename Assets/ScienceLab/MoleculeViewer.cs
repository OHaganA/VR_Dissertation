using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeViewer : MonoBehaviour {
    private Transform molecule;
	// Use this for initialization
	void Start () {
        molecule = this.gameObject.transform.GetChild(0);
	}
	
	// Update is called once per frame
	void Update () {
        molecule.Rotate(Vector3.up * Time.deltaTime * 10);
	}
}
