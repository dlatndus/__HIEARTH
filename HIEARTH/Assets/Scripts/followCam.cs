﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{

    public GameObject target; // 카메라가 따라갈 대상
    public float moveSpeed; // 카메라가 따라갈 속도
    private Vector3 targetPosition; // 대상의 현재 위치

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        if(target.transform.position.x > -2.5)
        {
            targetPosition.Set(target.transform.position.x, this.transform.position.y, this.transform.position.z);
            // vectorA -> B까지 T의 속도로 이동
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}