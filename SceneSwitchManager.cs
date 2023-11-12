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
        if (newScene.name == "Deep") // 第二个场景的名称
        {
            movement.instance.playerLight.SetActive(true); // 打开2D灯光
        }
        else
        {
            movement.instance.playerLight.SetActive(false); // 关闭2D灯光
        }
    }
}
