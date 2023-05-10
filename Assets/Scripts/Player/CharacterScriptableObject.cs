using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterScriptableObject", menuName = "ScriptableObjects/Character")]
public class CharacterScriptableObject : ScriptableObject
{
    [SerializeField]
    Sprite icon;
    public Sprite Icon { get => icon; private set => icon = value; }

    [SerializeField]
    new string name;
    public string Name { get => name; private set => name = value; }

    [SerializeField]
    GameObject startingWeapon;
    public GameObject StartingWeapon { get => startingWeapon; private set => startingWeapon = value; }

    //Base stats for the character
    [SerializeField]
    float maxHealth;    //Determines the maximum amount of HP for the character
    public float MaxHealth { get => maxHealth; private set => maxHealth = value; }

    [SerializeField]
    float recovery;     //Determines how much HP is generated for the character per second
    public float Recovery { get => recovery; private set => recovery = value; }

    [SerializeField]
    float moveSpeed;    //Modifies the movement speed of the character
    public float MoveSpeed { get => moveSpeed; private set => moveSpeed = value; }

    [SerializeField]
    float might;    //Modifies the damage of all attacks
    public float Might { get => might; private set => might = value; }

    [SerializeField]
    float projectileSpeed;    //Modifies the movement speed of all projectiles
    public float ProjectileSpeed { get => projectileSpeed; private set => projectileSpeed = value; }

    [SerializeField]
    float magnet;    //Modifies the movement speed of all projectiles
    public float Magnet { get => magnet; private set => magnet = value; }
}