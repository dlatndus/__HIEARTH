using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Transform player;
    public float jump;
    bool isjump = false;
    float thisy;
    Rigidbody2D rigid;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigid = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        thisy = player.position.y;
        if (isjump)
        {
            rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            if (player.transform.position.y >= thisy)
            {
                isjump = false;
            }
        }
    }

    public void Jumping()
    {
        isjump = true;
    }

    public void notJump()
    {
        isjump = true;
    }
}
