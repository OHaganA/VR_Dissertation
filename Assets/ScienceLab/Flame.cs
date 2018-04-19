using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour {
    public ParticleSystem flame;

    Gradient grad;
    Color startFlame1 = new Color(0.78823529411764705882352941176471f, 0.58039215686274509803921568627451f, 0.31764705882352941176470588235294f, 1f);
    Color startFlame2 = new Color(1f, 0.27058823529411764705882352941176f, 0f, 1f);

    Color yellowOrange1 = new Color(1f, 1f, 0.57647058823529411764705882352941f, 1f);
    Color yellowOrange2 = new Color(0.96078431372549019607843137254902f, 0.58823529411764705882352941176471f, 0.02745098039215686274509803921569f, 1f);

    Color red1 = new Color(1f, 0f, 0.18039215686274509803921568627451f, 1f);
    Color red2 = new Color(0.57254901960784313725490196078431f, 0.03529411764705882352941176470588f, 0.13725490196078431372549019607843f, 1f);

    Color lilac1 = new Color(0.8078431372549019607843137254902f, 0.76862745098039215686274509803922f, 0.97254901960784313725490196078431f, 1f);
    Color lilac2 = new Color(0.49019607843137254901960784313725f, 0.37254901960784313725490196078431f, 0.74901960784313725490196078431373f, 1f);

    Color greenBlue1 = new Color(0.09019607843137254901960784313725f, 0.75294117647058823529411764705882f, 0.34901960784313725490196078431373f, 1f);
    Color greenBlue2 = new Color(0.4f, 0.86274509803921568627450980392157f, 0.72549019607843137254901960784314f, 1f);

    Color appleGreen1 = new Color(0.35686274509803921568627450980392f, 0.76078431372549019607843137254902f, 0.21176470588235294117647058823529f, 1f);
    Color appleGreen2 = new Color(0f, 1f, 0.27058823529411764705882352941176f, 1f);
    private void Start()
    {
        grad = new Gradient();
        grad.SetKeys(new GradientColorKey[] { new GradientColorKey(startFlame1, 0.0f), new GradientColorKey(startFlame2, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f,0.806f), new GradientAlphaKey(0.0f, 1.0f) });
    }
    private void Update()
    {
        var colOverLifetime = flame.colorOverLifetime;
        colOverLifetime.enabled = true;
        colOverLifetime.color = grad;
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "Sodium(Clone)":
                Debug.Log("Sodium");
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(yellowOrange1, 0.0f), new GradientColorKey(yellowOrange2, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 0.806f), new GradientAlphaKey(0.0f, 1.0f) });
                break;
            case "Strontium(Clone)":
                Debug.Log("Strontium");
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(red1, 0.0f), new GradientColorKey(red2, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 0.806f), new GradientAlphaKey(0.0f, 1.0f) });
                break;
            case "Potassium(Clone)":
                Debug.Log("Potassium");
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(lilac1, 0.0f), new GradientColorKey(lilac2, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 0.806f), new GradientAlphaKey(0.0f, 1.0f) });
                break;
            case "Barium(Clone)":
                Debug.Log("Barium");
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(appleGreen1, 0.0f), new GradientColorKey(appleGreen2, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 0.806f), new GradientAlphaKey(0.0f, 1.0f) });
                break;
            case "Copper(Clone)":
                Debug.Log("Copper");
                grad.SetKeys(new GradientColorKey[] { new GradientColorKey(greenBlue1, 0.0f), new GradientColorKey(greenBlue2, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 0.806f), new GradientAlphaKey(0.0f, 1.0f) });
                break;
        }
        Debug.Log("Flame met");
    }
}
