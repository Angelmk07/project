using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 Move;
    [SerializeField] int moveSpeed = 200;
    private PlayerController playerController;
    private void Awake()
    {
        playerController = new PlayerController();
        rb = GetComponentInChildren<Rigidbody2D>();
        //Move = GetComponent<Vector2>();
        playerController.Enable();
       

    }
    private void Update()
    {
        Move = playerController.SliderMove.Rotatre.ReadValue<Vector2>();
        MoveSlider(Move);

    }
    void MoveSlider(Vector2 vector)
    {
        //Quaternion rotation = Quaternion.Euler(new Vector3( vector.x, 0, vector.y) * moveSpeed * Time.deltaTime);
        transform.Rotate( 0,0, vector.x);
    }
}
