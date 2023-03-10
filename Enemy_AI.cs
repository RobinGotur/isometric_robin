using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour

{
    Transform tr_Player;
    float f_RotSpeed = 1.0f;
    float f_MoveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation
            , Quaternion.LookRotation(tr_Player.position - transform.position)
            , f_RotSpeed * Time.deltaTime);

        transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
    }
}
