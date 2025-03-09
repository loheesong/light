using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightSource : MonoBehaviour
{
    private Light2D l;
    private int rayCount = 10;
    public LayerMask lightDetectionLayer;

    void Awake() {
        l = GetComponent<Light2D>();
    }

    #region Unity_func
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("aa"+ l.pointLightOuterAngle + "  "+transform.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        DetectObjectsInLightCone();
    }
    #endregion

    private void DetectObjectsInLightCone() {
        float angle = l.pointLightOuterAngle;
        float halfAngle = angle / 2f;
        float startAngle = transform.eulerAngles.z - halfAngle;
        float stepAngle = angle / (rayCount - 1);
        float maxDistance = l.pointLightOuterRadius;

        for (int i = 0; i < rayCount; i++) {
            float currentAngle = startAngle + (stepAngle * i);
            Vector2 direction = Quaternion.Euler(0, 0, currentAngle) * Vector2.up; 

            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, maxDistance, lightDetectionLayer);
            // Debug.DrawLine(transform.position, direction * maxDistance, Color.black, 10f);
            
            if (hit.collider != null && hit.collider.CompareTag("Player")) {
                Debug.Log("player");
                break;
            }
        }
    }
}
