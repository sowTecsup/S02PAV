using UnityEngine;

public class Player : MonoBehaviour
{
    private Health health = new();

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }

   // public void TakeDamage(int damage) =>  health.TakeDamage(damage);
}
