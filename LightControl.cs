using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightControl : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public Light2D pointLight;
    public float minLightIntensity = 1f;
    public float maxLightIntensity = 6f;
    private void Start()
    {
        pointLight = GetComponent<Light2D>();
    }
    private void Update()
    {
        // 获取鼠标位置
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 计算方向向量
        Vector3 direction = mousePosition - transform.position;
        direction.z = 0; // 2D游戏中，Z轴通常设置为0

        // 计算旋转角度
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 旋转聚光灯
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, angle - 90), rotationSpeed * Time.deltaTime);
        float normalizedHealth = movement.HealthShow / movement.instance.HealthMax;
        float newIntensity = Mathf.Lerp(minLightIntensity, maxLightIntensity, normalizedHealth);
        pointLight.intensity = newIntensity;
        if (pointLight.intensity >= 1) {
            if (movement.HealthShow >= 50)
            {
                pointLight.intensity = 6;
            }
            else if (movement.HealthShow >= 20)
            {
                pointLight.intensity = 4;


            }
            else if (movement.HealthShow >= 10)
            {
                pointLight.intensity = 2;
            }
            else { pointLight.intensity = 1; }
        }
    } }
