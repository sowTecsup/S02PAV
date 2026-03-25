using System;
using UnityEngine;
using UnityEngine.InputSystem;

public enum PlayerController
{
    Player1,
    Player2
}


public class Player : MonoBehaviour
{
    [SerializeField] private Health health = new();

    public Player TARGET;
    public PlayerController ControllerMap;

    [SerializeField] string PlayerName;
   
    [SerializeField]private Weapon weapon;

    public InputSystem_Actions inputs;

    public Vector2 moveInput;
    public int speed;

    private void Awake()
    {
        inputs = new();
    }
    private void OnEnable()
    {
        inputs.Enable();
        switch (ControllerMap)
        {
            case PlayerController.Player1:
                {
                    inputs.Player1.Move.performed += OnMoveAction;
                    inputs.Player1.Move.canceled += OnMoveAction;
                    inputs.Player1.Attack.performed += OnAttackAction;
                }
                break;
            case PlayerController.Player2:
                {
                    inputs.Player2.Move.performed += OnMoveAction;
                    inputs.Player2.Move.canceled += OnMoveAction;
                    inputs.Player2.Attack.performed += OnAttackAction;
                }
                break;
        }

    }

    private void OnAttackAction(InputAction.CallbackContext context)
    {
        Shoot(TARGET);
    }

    private void OnMoveAction(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (Vector3)moveInput * speed * Time.deltaTime;

       /* if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(TARGET);
        }*/
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(PlayerName + "|" + health.GetLife());
            
        }
    }
    public void TakeDamage(int damage)
    {
        Debug.Log(PlayerName + " : Ouch!" );
        health.TakeDamage(damage);
    }
    public void Shoot(Player Target)
    {

        Debug.Log(PlayerName + " : try to shoot");
        weapon.Shoot(Target);
    }






   // public void TakeDamage(int damage) =>  health.TakeDamage(damage);
}
