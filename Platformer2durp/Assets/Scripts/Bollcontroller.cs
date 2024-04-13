using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bollcontroller : MonoBehaviour
{
    int live = 3;
    [SerializeField] Rigidbody2D GameObject;
    
        void OnBecameInvisible()
        {
            transform.position = new Vector3(0, 0, 0);
            live--;
            Debug.Log("-1");
            GameObject.velocity = Vector3.zero;

        }



}
