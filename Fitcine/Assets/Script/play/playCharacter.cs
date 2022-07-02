using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class playCharacter : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int jumpForce;

    public AudioClip se;
    AudioSource audioSource;

    private bool isJumping = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            audioSource = GetComponent<AudioSource>();
            isJumping = true;
            Jump();
            audioSource.PlayOneShot(se);
        }

        //transforméÊìæ
        Transform rbTransform = this.transform;

        //ç¿ïWéÊìæ
        Vector3 rb_pos = rbTransform.position;

        if (rb_pos.y < -3.73f)
        {
            rb_pos.y = -3.73f;
            //ç¿ïWÇê›íË
            rbTransform.position = rb_pos;
            isJumping = false;
        }
        
    }
    void Jump()
    {
        
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        

    }
}