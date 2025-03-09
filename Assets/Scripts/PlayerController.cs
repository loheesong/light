using System.Runtime.CompilerServices;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    #region Movement_vars
    [SerializeField]
    private float moveSpeed = 3;
    [SerializeField]
    private float jumpHeight = 350;
    [SerializeField]
    private float maxSpeed = 6;
    private float x_input;
    Rigidbody2D rb;
    public bool canJump;
    #endregion

    #region Gameplay_vars
    private bool hasKey;
    #endregion

    #region Animation
    private Animator animator;
    #endregion

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.E)) {
            Interact();
        } else if (Input.GetKeyDown(KeyCode.Q)) {
            // reset level 
        } else if (Input.GetKeyDown(KeyCode.Tab)) {
            // switch control to shadow
        }
    }

    #region Movement_func
    private void Move() {
        x_input = Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector2(x_input * moveSpeed, 0));
        // currDirection = new Vector2(x_input, 0);

        if (rb.linearVelocity.x > maxSpeed) {
            rb.linearVelocity = new Vector2(maxSpeed, rb.linearVelocity.y);
        }
        if (rb.linearVelocity.x < -maxSpeed) {
            rb.linearVelocity = new Vector2(-maxSpeed, rb.linearVelocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("asdasd");
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump) {
            canJump = false;
            rb.AddForce(new Vector2(0, jumpHeight));
        }
    }
    #endregion

    #region Gameplay_func 
    private void Interact() {
        // return;
    }
    #endregion
}
