using UnityEngine;

public class Player : MonoBehaviour
{
    public Player TARGET;


    [SerializeField] string PlayerName;
    private Health health = new();
    [SerializeField]private Weapon weapon;


    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(TARGET);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(PlayerName + "|")
            health.GetLife();
        }
    }
    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }
    public void Shoot(Player Target)
    {
        weapon.Shoot(Target);
    }






   // public void TakeDamage(int damage) =>  health.TakeDamage(damage);
}
