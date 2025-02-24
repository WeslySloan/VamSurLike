using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem; // Player input Package



public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;


    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

        // GetAxis'Raw'("") rawÃß°¡·Î °ª ±ò²ûÇÏ°Ô ¹Ý¿µ
    }

    private void FixedUpdate()
    {
        //// Èû
        //rigid.AddForce (inputVec);

        //// ¼Óµµ
        //rigid.velocity = inputVec;

        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition (rigid.position + nextVec);
    }

    private void OnMove(InputValue value)   // Player input Package
    {
        inputVec = value.Get<Vector2>();
    }
}
