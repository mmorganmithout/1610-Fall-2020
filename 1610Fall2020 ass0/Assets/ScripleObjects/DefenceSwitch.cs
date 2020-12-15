using System;
using UnityEngine;

[CreateAssetMenu]
public class DefenceSwitch : ScriptableObject
{
    public enum Defences
    {
        Shield,
        Armor,
        Potions,
        ForceField,
        ExtraHealth
    }

    public Defences currentDefence;

    public void RunCurrentDefence()
    {
        switch (currentDefence)
        {
            case Defences.Shield:
                break;
            case Defences.Armor:
                break;
            case Defences.Potions:
                break;
            case Defences.ForceField:
                break;
            case Defences.ExtraHealth:
                break;
        }
    }
}