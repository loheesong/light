using UnityEngine;

public class CharacterController : MonoBehaviour
{
    #region Movement_vars
    [SerializeField]
    private float moveSpeed = 3;
    [SerializeField]
    private float jumpHeight = 350;
    [SerializeField]
    private float maxSpeed = 6;
    private float x_input;
    protected Rigidbody2D rb;
    public bool canJump;
    #endregion

    protected virtual void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    #region Movement_func
    protected void Move() {
        // Debug.Log("moveeeee");
        x_input = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector2(x_input * moveSpeed, 0));
        // currDirection = new Vector2(x_input, 0);

        if (rb.linearVelocity.x > maxSpeed) {
            rb.linearVelocity = new Vector2(maxSpeed, rb.linearVelocity.y);
        }
        if (rb.linearVelocity.x < -maxSpeed) {
            rb.linearVelocity = new Vector2(-maxSpeed, rb.linearVelocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump) {
            canJump = false;
            rb.AddForce(new Vector2(0, jumpHeight * Mathf.Sign(rb.gravityScale)));
        }
    }
    #endregion
}
