using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class ShadowController : CharacterController
{
    private float gravityDown = 1f;
    private float gravityUp = -1f;
    private bool isMovementEnabled = false;

    public bool IsMovementEnabled {
        get => isMovementEnabled;
        set => isMovementEnabled = value;
    }

    protected override void Awake() {
        base.Awake();
        rb.gravityScale = gravityDown;
        Debug.Log("asdasd" + this.enabled);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("bbb" + IsMovementEnabled);
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log("outside if" + isMovementEnabled);
        if (isMovementEnabled) {
            Debug.Log("inside if");
            Move();
        }
        Debug.Log("shadow");
    }

    
}
