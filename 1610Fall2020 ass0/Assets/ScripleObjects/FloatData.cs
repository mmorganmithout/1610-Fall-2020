using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float number)
    {
        value += number;
        Debug.Log(value + " " + this.name);
    }
}
