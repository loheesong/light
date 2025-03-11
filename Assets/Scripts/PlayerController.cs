using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerController : CharacterController
{   
    #region Gameplay_vars
    private bool hasKey;
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
        if (GameManager.Instance.isPlayerActive) {
            Move();
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            Interact();
        } else if (Input.GetKeyDown(KeyCode.Q)) {
            // reset level 
        } 
    }

    #region Gameplay_func 
    private void Interact() {
        // return;
    }
    #endregion
}
