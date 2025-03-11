using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class ShadowController : CharacterController
{
    private float gravityDown = 1f;
    private float gravityUp = -1f;

    protected override void Awake() {
        base.Awake();
        rb.gravityScale = gravityDown;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if (!GameManager.Instance.isPlayerActive) {
            Debug.Log("inside if");
            Move();
        }
    }
}
