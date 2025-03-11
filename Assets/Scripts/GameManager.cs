using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    private int currentLevel = 1;
    private int maxLevel;

    #region PlayerControls_var
    public bool isPlayerActive = true;
    #endregion

    void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            isPlayerActive = !isPlayerActive; 
        } 
    }
}
