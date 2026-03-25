using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int damage;
    private int ammo = 10;
    void Start()
    {
        
    }
    public void Shoot(Player target)
    {
        //->
        if (target == null || ammo <= 0)
            return;


        //->if
        if (ammo >= 1)
        {
            target.TakeDamage(damage);
            ammo--;
            Debug.Log("Shoot");
        }
        else
        {
            Debug.Log("No tiene munición");
        }


        //-> else
    }


}
