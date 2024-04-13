using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovmet : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 Move;
    
    [SerializeField] int jumpforse = 300;
    [SerializeField] int moveSpeed = 4;
    private PlayerController playerController;

    private void Awake()
    {
        playerController = new PlayerController();
        rb = GetComponent<Rigidbody2D>();
        //Move = GetComponent<Vector2>();
        playerController.Enable();
        playerController.PlayerM.Jump.performed += Jump_performed;

    }

    private void OnDisable()
    {
        playerController.PlayerM.Jump.performed -= Jump_performed;
    }

    private void Jump_performed(InputAction.CallbackContext obj)
    {
        rb.AddForce(new Vector2(0f, jumpforse));
    }

    private void Update()
    {
        Move = playerController.PlayerM.Move.ReadValue<Vector2>();
        MovePlayer(Move);
    }
    void MovePlayer(Vector2 vector)
    {
        transform.position += new Vector3(vector.x, 0, vector.y) * moveSpeed * Time.deltaTime;
    }

}
