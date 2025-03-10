using UnityEngine;

public class FeetCollider : MonoBehaviour
{
    bool isFloor(GameObject gameObject) {
        return gameObject.layer == LayerMask.NameToLayer("Floor");
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isFloor(collision.gameObject))
        {
            GetComponentInParent<CharacterController>().canJump = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (isFloor(collision.gameObject)) {
            GetComponentInParent<CharacterController>().canJump = false;
        }
    }
}