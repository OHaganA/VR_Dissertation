using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcidHandler : MonoBehaviour {

    public Slider phSlider;
    public Text phText;
    public GameObject dropper;
    public GameObject water;

    Renderer rend;
    public Color[] waterColors;

    public void acidButton()
    {
        phSlider.value -= 1;
        StartCoroutine(acidDrop());
    }

    public void alkaliButton()
    {
        phSlider.value += 1;
        StartCoroutine(acidDrop());
    }


    private void Start()
    {
        rend = water.GetComponent<Renderer>();
        rend.material.shader = Shader.Find("FX/Water");
    }
    private void Update()
    {
        phText.text = "Current pH = " + phSlider.value;
        rend.material.SetColor("_RefrColor", waterColors[(int) phSlider.value]);
    }


    IEnumerator acidDrop()
    {
        dropper.SetActive(true);
        yield return new WaitForSeconds(1);
        dropper.SetActive(false);
    }
}
