using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerController : CharacterController
{   
    #region Gameplay_vars
    private bool hasKey;
    private bool isMovementEnabled = true;
    public bool IsMovementEnabled {
        get => isMovementEnabled;
        set => isMovementEnabled = value;
    }
    #endregion

    #region Animation
    private Animator animator;
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovementEnabled) {
            Move();
        }
        // Debug.Log("player");
        if (Input.GetKeyDown(KeyCode.E)) {
            Interact();
        } else if (Input.GetKeyDown(KeyCode.Q)) {
            // reset level 
        } else if (Input.GetKeyDown(KeyCode.Tab)) {
            // switch control to shadow
        }
    }

    #region Gameplay_func 
    private void Interact() {
        // return;
    }
    #endregion
}
