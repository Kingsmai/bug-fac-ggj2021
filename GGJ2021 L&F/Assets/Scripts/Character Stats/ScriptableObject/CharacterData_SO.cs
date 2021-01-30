using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���Ҽ�Create�˵��д���"Character Stats/Data"ѡ��
[CreateAssetMenu(fileName = "New Data", menuName = "Character Stats/Data")]
public class CharacterData_SO : ScriptableObject
{
    [Header("Stats Info")]
    
    public int maxhealth;

    public int currentHealth;

    public int baseDefense;

    public int currentDefense;
}
