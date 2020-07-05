using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionPlayer : MonoBehaviour
{
    public Rigidbody2D RB2D;

    public Transform GroundCheck;

    public LayerMask GroundLayer;

    public float circleRadius;

    public bool IsTouchingGround;

    public float Speed;

    public float JumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsTouchingGround = Physics2D.OverlapCircle(GroundCheck.position, circleRadius, GroundLayer);

        //if (Press On ->){MoveR}
        if(Input.GetKey(KeyCode.RightArrow))
        {
            MoveR();
        }

        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            MoveL();
        }
        else{
            RB2D.velocity = new Vector2(0, RB2D.velocity.y);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(IsTouchingGround)
            {
                Jump();
            }
        }

    }

    void MoveR()
    {
        //Run Player To Right With Speed 5
        RB2D.velocity = new Vector2(Speed, RB2D.velocity.y);
    }

        void MoveL()
    {
        //Run Player To Left With Speed 5
        RB2D.velocity = new Vector2(-Speed, RB2D.velocity.y);
    }

    void Jump()
    {
        RB2D.velocity = new Vector2(RB2D.velocity.x, JumpForce);
    }
}
