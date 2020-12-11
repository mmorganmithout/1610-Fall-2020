using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float number)
    {
        value += number;
        Debug.Log(value + " " + this.name);
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }
    
    public void DisplayValue(Image img)
    {
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
