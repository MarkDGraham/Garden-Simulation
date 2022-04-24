using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    // Variables
    public PlayerInputActions playerActions;
    private InputAction move;
    private InputAction interaction;
    private float speed = 10f;

    private Vector2 moveDirection = Vector2.zero;

    private void Awake()
    {
        playerActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        move = playerActions.Player.Move;
        move.Enable();

        interaction = playerActions.Player.Interaction;
        interaction.Enable();
        interaction.performed += Interact;
    }

    private void OnDisable()
    {
        move.Disable();
        interaction.Disable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveDirection = move.ReadValue<Vector2>();
        transform.Translate(moveDirection.x * speed * Time.deltaTime, 0, moveDirection.y * speed * Time.deltaTime);
    }

    // Interact 
    private void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("Pew Pew");
    }
}
