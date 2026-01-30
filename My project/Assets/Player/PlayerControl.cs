using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Animator anim;

    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody2D = gameObject.GetComponentInParent<Rigidbody2D>();
        this.anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 move = new Vector2(horizontal, vertical);
        rigidbody2D.velocity = move * moveSpeed;

        bool isRunning = (Mathf.Abs(horizontal) > 0.1f) || (Mathf.Abs(vertical) > 0.1f);
        anim.SetBool("run 0", isRunning);
    }
}
