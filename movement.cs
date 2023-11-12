using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    //[SerializeField] private fieldofview fieldofview;
    //public float movespeed;
    private Vector3 initialPosition;
    public float healthCost = 10f;
    public TextMeshProUGUI healthText;
    public static float HealthNow = 100;
    public static int HealthShow = 100;
    public int HealthMax;
    public int damagePerSecond = 1; // ÿ���Ѫ���˺�ֵ
    private float timeElapsed = 0f;
//    public GameObject testlight;
    public static movement instance;
    public GameObject playerLight;
    private float MoveH, MoveV;
    //  public GameObject gameOverScreen; // ��Ϸʧ�ܻ���

    //private bool isGameOver = false;


    private Animator animator;

    //public LayerMask solidObjectsLayer;

    //private Vector3 offset;

    private Rigidbody2D rb;

    [SerializeField] private float movespeed = 0.1f;

    [SerializeField] private float Newmovespeed = 1f;

    public string Pw;

    private void Awake()
    {
        //UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        //Debug.Log("��ǰ����: " + scene.name);
        animator = GetComponent<Animator>();
        //if (scene.name == "start") {
        //    Destroy(gameObject);
        //    instance = null;
        //}
        //else
        //{
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }

    }
    //  }
    public void DestroyPlayer()
    {
        Destroy(gameObject); // ���ٵ�������
    }
    private void Start()
    {
        HealthNow = HealthMax;
        HealthShow = (int)HealthNow;
        initialPosition = transform.position;
        //V_Object vObject = CreateBasicUnit(transform, new Vector3(500, 680), 30f, GameAssets.i.m_MarineSpriteSheet);
        rb = GetComponent<Rigidbody2D>();

        healthText.text = HealthShow.ToString() + "%";
        //offset = Camera.main.transform.position - transform.position;
    }


    private void Update()
    {

    }

    private void FixedUpdate()
    {
        //if (!isGameOver)
        //{
        //    CheckPlayerHealth();
        //}
        if (HealthNow > 0)
        {
            timeElapsed += Time.deltaTime;

            // ���ʱ��ﵽ1�룬ִ�е�Ѫ�߼�

            if (timeElapsed >= 1f)
            {
                timeElapsed = 0f; // ����ʱ��
                if (playerLight.activeSelf)
                {
                    // �۳�Ѫ��
                    HealthNow -= damagePerSecond;
                    HealthShow = Mathf.RoundToInt(HealthNow);
                    healthText.text = HealthShow.ToString() + "%";
                }
                else {
                    HealthNow -= damagePerSecond*2;
                    HealthShow = Mathf.RoundToInt(HealthNow);
                    healthText.text = HealthShow.ToString() + "%";
                }
            }
        }


        MoveH = Input.GetAxisRaw("Horizontal") * movespeed * Newmovespeed;
        MoveV = Input.GetAxisRaw("Vertical") * movespeed * Newmovespeed;
        //print("�������"+ Input.GetAxisRaw("Horizontal")+","+ Input.GetAxisRaw("Vertical"));
        rb.velocity = new Vector2(MoveH, MoveV);
        Vector2 Direction = new Vector2(MoveH, MoveV);
        //input.x = MoveH;
        //input.y = MoveV;
        if (Direction != Vector2.zero)
        {
            animator.SetFloat("MoveX", MoveH);
            animator.SetFloat("MoveY", MoveV);
        }

        MoveUp();
    }
    //�����ƶ�
    void MoveUp()
    {
        if (HealthNow > 0)
        {
            if (MoveH != 0 || MoveV != 0)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    Newmovespeed = 5f;
                    float healthConsumption = healthCost * Time.deltaTime;

                    HealthNow -= healthConsumption;


                }
                else
                {
                    Newmovespeed = 2f;
                }

            }


        }
    }
    //IEnumerator Move(Vector3 targetPos) 
    //{
    //    ismoving = true;
    //    while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
    //    {
    //        transform.position = Vector3.MoveTowards(transform.position, targetPos, movespeed * Time.deltaTime);
    //        yield return null;
    //    }
    //    transform.position=targetPos;
    //    ismoving = false;
    //}
    //private bool IsWalkable(Vector3 targetpos) {
    //    if (Physics2D.OverlapCircle(targetpos, 0.3f, solidObjectsLayer)!=null) {
    //        return false;
    //    }
    //    return true;
    //}
    //public void ResetPositionToInitial()
    //{
    //    transform.position = initialPosition;
    //}
    //void CheckPlayerHealth()
    //{
    //    if (HealthNow <= 0)
    //    {
    //        HealthNow = 0;
    //        GameOver();
    //    }
    //}
    //void GameOver()
    //{
    //    isGameOver = true;
    //    Time.timeScale = 0;
    //    // ��ʾ��Ϸʧ�ܻ���
    //    gameOverScreen.SetActive(true);

    //}
    public void DestroyGameManager()
    {
        Destroy(gameObject);
        instance = null;
    }
    public void IncreaseHealth(int amount)
    {
        HealthNow += amount;
        if (HealthNow > HealthMax)
        {
            HealthNow = HealthMax;
        }
    }
}
