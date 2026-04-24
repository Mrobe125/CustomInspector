using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewAbility", menuName = "Ability System/Ability")]
public class AbilityData : ScriptableObject
{
    public string abilityName;
    public Sprite icon;

    [Range(0, 100)]
    public float manaCost;
    public float cooldown;

    public List<AbilityEffect> effects = new List<AbilityEffect>();

    public void TriggerPreview()
    {
        Debug.Log($"<color=cyan>Testing Ability: {abilityName}</color>");
    }
}

[System.Serializable]
public class AbilityEffect
{
    public enum EffectType { Damage, Heal, Buff }
    public EffectType type;
    public float intensity;
}