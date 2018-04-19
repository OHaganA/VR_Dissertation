using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameHandler : MonoBehaviour {
    public GameObject sodiumChunk;
    public GameObject strontiumChunk;
    public GameObject potassiumChunk;
    public GameObject bariumChunk;
    public GameObject copperChunk;

    public void ChunkSpawn(string chunkname)
    {
        GameObject clone;
        switch (chunkname)
        {
            case "Sodium":
                Destroy(GameObject.Find("Sodium(Clone)"));
                clone = Instantiate(sodiumChunk, transform.position, Quaternion.identity) as GameObject;
                break;
            case "Strontium":
                Destroy(GameObject.Find("Strontium(Clone)"));
                clone = Instantiate(strontiumChunk, transform.position, Quaternion.identity) as GameObject;
                break;
            case "Potassium":
                Destroy(GameObject.Find("Potassium(Clone)"));
                clone = Instantiate(potassiumChunk, transform.position, Quaternion.identity) as GameObject;
                break;
            case "Barium":
                Destroy(GameObject.Find("Barium(Clone)"));
                clone = Instantiate(bariumChunk, transform.position, Quaternion.identity) as GameObject;
                break;
            case "Copper":
                Destroy(GameObject.Find("Copper(Clone)"));
                clone = Instantiate(copperChunk, transform.position, Quaternion.identity) as GameObject;
                break;
        }
    }

}
