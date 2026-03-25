using System;
using Unity.VisualScripting;
using UnityEngine;


[Serializable]
public class Health 
{
    [SerializeField] private int value = 10;

    public void TakeDamage(int damage)
    {
        value -= damage;
        if (value < 0)
            value = 0;

        Debug.Log("Daño: " + damage + " Vida restante: " + value);
    }
    public int GetLife()
    {
        
        return value;
    }

}
