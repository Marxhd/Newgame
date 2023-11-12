using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchManager : MonoBehaviour
{
    private void Start()
    {
        SceneManager.activeSceneChanged += HandleSceneChange;
    }

    private void HandleSceneChange(Scene previousScene, Scene newScene)
    {
        if (newScene.name == "Deep") // �ڶ�������������
        {
            movement.instance.playerLight.SetActive(true); // ��2D�ƹ�
        }
        else
        {
            movement.instance.playerLight.SetActive(false); // �ر�2D�ƹ�
        }
    }
}
