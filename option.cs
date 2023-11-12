using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
    public GameObject set;
 //   public GameObject slide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setting() {
        set.SetActive(true);
 //       slide.SetActive(true);
        Time.timeScale = 0;
    }
    public void beign()
    {
        set.SetActive(false);
 //       slide.SetActive(false);
        Time.timeScale = 1;
    }

}
