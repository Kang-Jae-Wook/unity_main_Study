using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Animator m_Animator;
    public float m_Speed;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (m_Animator)
        {
            m_Animator.SetBool("isMove", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -m_Speed);
            m_Animator.SetBool("isMove", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, m_Speed);
            m_Animator.SetBool("isMove", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(m_Speed, 0, 0);
            m_Animator.SetBool("isMove", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-m_Speed, 0, 0);
            m_Animator.SetBool("isMove", true);
        }

    }

}
