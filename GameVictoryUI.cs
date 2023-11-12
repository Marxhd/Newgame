using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameVictoryUI : MonoBehaviour
{
    public GameObject victoryPanel; // 引用游戏胜利的面板

    void Start()
    {
        victoryPanel.SetActive(false); // 初始化时将胜利面板隐藏
    }

    public void ShowVictoryPanel()
    {
        Time.timeScale = 0; // 暂停游戏
        victoryPanel.SetActive(true); // 显示胜利面板
    }

    public void ResumeGame()
    {
        Time.timeScale = 1; // 恢复游戏
        victoryPanel.SetActive(false); // 隐藏胜利面板
    }
}
