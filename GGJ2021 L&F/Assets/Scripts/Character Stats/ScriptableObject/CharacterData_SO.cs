using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//在右键Create菜单中创建"Character Stats/Data"选项
[CreateAssetMenu(fileName = "New Data", menuName = "Character Stats/Data")]
public class CharacterData_SO : ScriptableObject
{
    [Header("Stats Info")]
    
    public int maxhealth;

    public int currentHealth;

    public int baseDefense;

    public int currentDefense;
}
