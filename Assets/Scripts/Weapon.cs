using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private int ammo = 10;
    void Start()
    {
        
    }
    public void Shoot(Player target)
    {
        //->
        if (target == null || ammo <= 0)
        {
            Debug.Log("No tiene munición");
            return; 
        }


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
