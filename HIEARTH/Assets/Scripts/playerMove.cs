using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Transform player;
    public float Speed;
    bool right,left;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = player.GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            player.transform.position += Vector3.right * Speed * Time.deltaTime;
            player.transform.localScale = new Vector3(0.45f, 0.45f, 1f);
        }
        if (left)
        {
            player.transform.position += Vector3.left * Speed * Time.deltaTime;
            player.transform.localScale = new Vector3(-0.45f, 0.45f, 1f);
        }
    }

    public void Up()
    {
        right = true;
    }
    public void Dawn()
    {
        left = true;
    }
    public void BackUp()
    {
        left = false;
    }
    public void BackDown()
    {
        right = false;
    }
}
