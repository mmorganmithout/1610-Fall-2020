using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image img;
    public void Start()
    {
        img = GetComponent<Image>();
    }

    public void DisplayValue(FloatData data)
    {
        img.fillAmount = data.value;
    }
}
