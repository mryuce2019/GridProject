using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CreatGrid : MonoBehaviour
{



    [SerializeField]
    GameObject myprofabs;

    [SerializeField]
    Button btnn;

    [SerializeField]
    InputField cloumnSize;

    [SerializeField]
    Text uyariText;



    [SerializeField]
    Sprite normalSprite;

  

    public List<Button> Buttonlar;
   

   




    string asagi ;
    string yukari;
    string sol;
    string sag;
   
    private static CreatGrid _instance;
    Komsular komsular;
    public List<Komsular> komsuList;
    public static CreatGrid Instance
    {

        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<CreatGrid>();
                if (_instance == null)
                {


                    GameObject go = new GameObject();
                    go.name = typeof(CreatGrid).Name;
                    _instance = go.AddComponent<CreatGrid>();
                    DontDestroyOnLoad(go);

                }
            }
            return _instance;

        }

    }







    private void Start()
    {

        cloumnSize.text = 4.ToString();//grid size başlangıç değeri atandı.

        uyariText.gameObject.SetActive(false);


        ReloadGrid();

    }



    public void ReloadGrid()

    {
        if (uyariText.gameObject.activeInHierarchy)
        {
            uyariText.gameObject.SetActive(false);

        }
        GameObject[] killAll;
        killAll = GameObject.FindGameObjectsWithTag("myTag");
        for (int i = 0; i < killAll.Length; i++)
        {
            Destroy(killAll[i].gameObject);
        }
        komsular = null;
        komsuList = null;
        komsuList = new List<Komsular>();
        Buttonlar = null;
        Buttonlar = new List<Button>();
        if (Int32.Parse(cloumnSize.text) <= 6 && Int32.Parse(cloumnSize.text) >= 3)
        {
            for (int i = 0; i < Int32.Parse(cloumnSize.text); i++)
            {
                GameObject go = (GameObject)Instantiate(myprofabs);
                
                go.transform.parent = transform;
                for (int j = 0; j < Int32.Parse(cloumnSize.text); j++)
                {


             
                  Button btn = (Button)Instantiate(btnn);

                    btn.GetComponent<Image>().sprite = normalSprite;
                   btn.transform.parent = go.transform;
                    btn.name = "button" + "[" + i + "]" + "[" + j + "]";
                    //sag
                    if (j+1 >=Int32.Parse(cloumnSize.text))
                    {
                        sag = "yok";
                    }
                    else
                    {
                        int indisDeger = j + 1;
                        sag = "button" + "[" + i + "]" + "[" + indisDeger + "]";
                        //[j+1][i] sağ button
                       
                    }
                    //sol
                    if (j-1<0)
                    {
                        sol = "yok";
                    }
                    else
                    {
                        int indisDeger = j-1;
                        sol = "button" + "[" + i + "]" + "[" + indisDeger + "]";
                        //[j-1][i] sol button
                    }
                    if (i-1<0)
                    {
                        yukari = "yok";
                        //ben [i][j]
                        //[i-1][j] yukarı button
                    }
                    else
                    {
                        int indisDeger = i - 1;
                        yukari = "button" + "[" + indisDeger + "]" + "[" + j + "]";
                    }
                    if (i + 1 >= Int32.Parse(cloumnSize.text))
                    {
                        asagi = "yok";
                    }
                    else
                    {
                        int indisDeger = i+1;
                        asagi = "button" + "[" + indisDeger + "]" + "[" + j + "]";
                        //[i+1][j] aşağı button
                    }


                   
                   
                        komsular = new Komsular(btn, sag, sol, asagi, yukari);
                        komsuList.Add(komsular);

                    Buttonlar.Add(btn);

                   


                }

            }
        }
        else
        {
            uyariText.gameObject.SetActive(true);
        }

    }
}

