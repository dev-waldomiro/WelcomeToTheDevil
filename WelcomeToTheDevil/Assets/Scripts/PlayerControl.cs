using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public LayerMask isGround;
    public Transform groundCheck;

    public bool jumpToGo;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float checkRadius;

    [Range(1,10)]
    public float jumpVelocity;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {

        jumpToGo = Physics2D.OverlapCircle(groundCheck.position, checkRadius, isGround);

        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpToGo == true){
            rb.velocity = Vector2.up * jumpVelocity;
            jumpToGo = false;
        }
        if (rb.velocity.y < 0) {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
