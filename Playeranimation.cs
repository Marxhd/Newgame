using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeranimation : MonoBehaviour
{
    //public Animator animator;
    //public string[] Anima = {"down","up","LidlLeft","Lidlright" };
    int lastDirection;
    private void Awake()
    {

 //       anim = GetComponent<Animation>();
    }
    //public void serDirection(Vector2 _direction)
    //{
    //    string[] directionarray = null;
    //    if (_direction.magnitude < 0.01)
    //    {
    //        directionarray = Anima;
    //    }
    //    anim.Play(directionarray[lastDirection]);
    //}
    // Start is called before the first frame update
    void Start()
    {
        //if (gameObject.tag == "Player")
        //{
        //    movement.instance.DestroyGameManager();
        //}
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            Destroy(player);
        }
        GameObject uiParameter = GameObject.Find("UIparameter");

        if (uiParameter != null)
        {
            // ����UI���
            Destroy(uiParameter);
        }
        GameObject Gameover1 = GameObject.Find("GameObject1");

        if (Gameover1 != null)
        {
            // ����UI���
            Destroy(Gameover1);
        }
        GameObject Chat2 = GameObject.Find("w");

        if (Chat2 != null)
        {
            // ����UI���
            Destroy(Chat2);
        }
        GameObject Chat3 = GameObject.Find("Open");

        if (Chat3 != null)
        {
            // ����UI���
            Destroy(Chat3);
        }
        GameObject Chat = GameObject.Find("ChatBox");

        if (Chat != null)
        {
            // ����UI���
            Destroy(Chat);
        }
    }

    // Update is called once per frame
    void Update()
    {
 //       anim.Play();
    }
    void Animate() {
 //       animator.SetFloat("Horizontal", movementDirection.x);
    }
}
