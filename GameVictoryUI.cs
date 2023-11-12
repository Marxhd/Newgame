using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameVictoryUI : MonoBehaviour
{
    public GameObject victoryPanel; // ������Ϸʤ�������

    void Start()
    {
        victoryPanel.SetActive(false); // ��ʼ��ʱ��ʤ���������
    }

    public void ShowVictoryPanel()
    {
        Time.timeScale = 0; // ��ͣ��Ϸ
        victoryPanel.SetActive(true); // ��ʾʤ�����
    }

    public void ResumeGame()
    {
        Time.timeScale = 1; // �ָ���Ϸ
        victoryPanel.SetActive(false); // ����ʤ�����
    }
}
