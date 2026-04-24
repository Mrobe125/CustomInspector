using UnityEngine;
using System.Collections.Generic;

public enum AbilityType { Magic, Physical, Utility }
public enum TargetType { Self, Enemy, Area }

[System.Serializable]
public class AbilityEntry
{
    public string name;
    public AbilityType type;
    public int cost;
    public float duration;
    public TargetType target;
}

[CreateAssetMenu(fileName = "NewAbilitySystem", menuName = "Systems/Ability System")]
public class AbilitySystem : ScriptableObject
{
    [Header("Global Settings")]
    public float globalCooldown = 1.0f;

    [Space]
    public List<AbilityEntry> abilities = new List<AbilityEntry>();
}