using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public CharacterData_SO characterData;

    #region Read_SO
    public int MaxHealth 
    {
        get{ if (characterData != null) return characterData.maxhealth; else return 0; }
        set{ characterData.maxhealth = value; }
    }

    public int CurrentHealth
    {
        get { if (characterData != null) return characterData.currentHealth; else return 0; }
        set { characterData.currentHealth = value; }
    }

    public int BaseDefense
    {
        get { if (characterData != null) return characterData.baseDefense; else return 0; }
        set { characterData.baseDefense = value; }
    }

    public int CurrentDefense
    {
        get { if (characterData != null) return characterData.currentDefense; else return 0; }
        set { characterData.currentDefense = value; }
    }
    #endregion
}
