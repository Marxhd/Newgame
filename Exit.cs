using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    //private Transform target;
    public string ScenesName;
    [SerializeField] private string newscenePw;

    // Start is called before the first frame update
    //private void Start() {
    //    target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    //}


    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Player"){
            movement.instance.Pw = newscenePw;
            //SceneManager.LoadScene(ScenesName);
            FindFirstObjectByType<Scenefader>().fadeto(ScenesName);
        }
    }
}
