using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class playCharacter : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int jumpForce;

    private bool isJump = false;

    public AudioClip Se;
    AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            audioSource = GetComponent<AudioSource>();
            isJump = true;
            Jump();
            audioSource.PlayOneShot(Se);
        }

        //transforméÊìæ
        Transform rbTransform = this.transform;

        //ç¿ïWéÊìæ
        Vector3 rb_pos = rbTransform.position;

        if(rb_pos.y < -3.73f)
        {
            isJump = false;
            rb_pos.y = -3.73f;
            rbTransform.position = rb_pos;
        }
    }
    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}