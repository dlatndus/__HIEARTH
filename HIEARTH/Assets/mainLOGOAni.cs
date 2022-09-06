using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainLOGOAni : MonoBehaviour

{
    public float speed = 3.0f;
    Vector2 movement = new Vector2();

    void Start()
    {
        movement.y = movement.y * speed;
        print("asdf");
    }
}
