using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] Bola, Colisoes;
    public Transform[] local;
    public Text[] texto;
    public int points, pontosFase, tempoFase, tempoS;

    //private float recebe = 18.24f, xS = 0.0056f, localD = 0.1205f, x0 = -0.2900729f, x1 = -0.1453888f, x2 = -0.0007045491f, x3 = 0.1439797f, x4 = 0.2886639f;
    private MouseRScript MR;
    private MouseLScript ML;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        MR = GameObject.Find("MouseR").GetComponent<MouseRScript>();
        ML = GameObject.Find("MouseL").GetComponent<MouseLScript>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        texto[0].text = "Pointos: " + points;
        //----------------------------------------------------------------------------------------------------------------------------------
        #region Bot�o R
        if (Input.GetButtonDown("Fire2"))
        {
            if (ML.bloco && MR.bloco)
            {
                MR.bloco.transform.position = ML.transform.position;
                ML.bloco.transform.position = MR.transform.position;
            }else
            if(!ML.bloco)
            {
                MR.bloco.transform.position = ML.transform.position;
            }else
            {
                ML.bloco.transform.position = MR.transform.position;
            }
        }
        #endregion
        if (Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("Menu");
        }
        /*
        timer5 += Time.deltaTime;
        if(timer5 >= tempoFase)
       {
            localD = local[0].transform.position.y - 1.15f;
            local[0].transform.position = Vector3.Lerp(transform.position, new Vector2(x0, localD), 4);
            local[1].transform.position = Vector3.Lerp(transform.position, new Vector2(x1, localD), 4);
            local[2].transform.position = Vector3.Lerp(transform.position, new Vector2(x2, localD), 4);
            local[3].transform.position = Vector3.Lerp(transform.position, new Vector2(x3, localD), 4);
            local[4].transform.position = Vector3.Lerp(transform.position, new Vector2(x4, localD), 4);

            recebe = Sobe.transform.position.y + 1.15f;
            Sobe.transform.position = Vector3.Lerp(transform.position, new Vector2(xS, recebe), 4);
            timer5 = 0;
        }
        */
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    #region Spawns
    public void Spawn1()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[0].position.x, local[0].position.y, 0), Quaternion.identity);
    }
    public void Spawn2()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[1].position.x, local[1].position.y, 0), Quaternion.identity);
    }
    public void Spawn3()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[2].position.x, local[2].position.y, 0), Quaternion.identity);
    }
    public void Spawn4()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[3].position.x, local[3].position.y, 0), Quaternion.identity);
    }
    public void Spawn5()
    {
        Instantiate(Bola[(int)Random.Range(0, 5)], new Vector3(local[4].position.x, local[4].position.y, 0), Quaternion.identity);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------
}
