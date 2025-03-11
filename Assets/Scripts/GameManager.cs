using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    private int currentLevel = 1;
    private int maxLevel;

    #region PlayerControls_var
    private bool isPlayerActive = true;
    public GameObject player;
    public GameObject shadow;
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetActiveCharacter(isPlayerActive); // set to player
        Debug.Log(shadow.GetComponent<ShadowController>().IsMovementEnabled);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("gm " + isPlayerActive);
        if (Input.GetKeyDown(KeyCode.Tab)) {
            isPlayerActive = !isPlayerActive; 
            SetActiveCharacter(isPlayerActive);
        }    
    }

    void SetActiveCharacter(bool isPlayerActive) {
        player.GetComponent<PlayerController>().IsMovementEnabled = isPlayerActive;
        shadow.GetComponent<ShadowController>().IsMovementEnabled = !isPlayerActive;
    }
}
