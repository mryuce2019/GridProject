using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

  

    [SerializeField]
    Sprite _sprite;

    [SerializeField]
    Sprite normalSprite;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame

    public void GameKontrol(Button btn)
    {

        btn.GetComponent<Image>().sprite = _sprite;
        int sayy = 0;




        for (int i = 0; i < CreatGrid.Instance.komsuList.Count; i++)
        {
            if (btn == CreatGrid.Instance.komsuList[i].getBntt())
            {

                CreatGrid.Instance.Buttonlar[i].interactable = false;


                if (CreatGrid.Instance.komsuList[i].getsag() != "yok")//sağda buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getsag() == CreatGrid.Instance.Buttonlar[kars].name)//sağdaki butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {
                                TekrarKontrol(CreatGrid.Instance.Buttonlar[kars]);
                                sayy++;


                            }
                            else
                            {
                                Debug.Log("sağ boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("sağda button yok");
                }




                if (CreatGrid.Instance.komsuList[i].getsol() != "yok")//solda buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getsol() == CreatGrid.Instance.Buttonlar[kars].name)//soldaki butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {

                                sayy++;
                                TekrarKontrol(CreatGrid.Instance.Buttonlar[kars]);

                            }
                            else
                            {
                                Debug.Log("sol boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("solda button yok");
                }



                if (CreatGrid.Instance.komsuList[i].getyukari() != "yok")//yukarda buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getyukari() == CreatGrid.Instance.Buttonlar[kars].name)//soldaki butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {

                                sayy++;
                                TekrarKontrol(CreatGrid.Instance.Buttonlar[kars]);
                                Debug.Log("yukarısı dolu :)");
                            }
                            else
                            {
                                Debug.Log("yukarısı boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("yukarda komsu yok:)");
                }





                if (CreatGrid.Instance.komsuList[i].getasagi() != "yok")//asagi buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getasagi() == CreatGrid.Instance.Buttonlar[kars].name)//aşağı butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {

                                sayy++;
                                TekrarKontrol(CreatGrid.Instance.Buttonlar[kars]);
                                Debug.Log("asagi dolu :)");
                            }
                            else
                            {
                                Debug.Log("aşağı boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("aşağıda komsu yok:)");

                }

             
                if (sayy >= 2)
                {
                    for (int j = 0; j < CreatGrid.Instance.Buttonlar.Count; j++)
                    {
                        CreatGrid.Instance.Buttonlar[j].interactable = true;
                        CreatGrid.Instance.Buttonlar[j].GetComponent<Image>().sprite = normalSprite;
                    }
                }


            }

        }




    }



    public void TekrarKontrol(Button btn)
    {

    
        int sayy = 0;




        for (int i = 0; i < CreatGrid.Instance.komsuList.Count; i++)
        {
            if (btn == CreatGrid.Instance.komsuList[i].getBntt())
            {

                CreatGrid.Instance.Buttonlar[i].interactable = false;


                if (CreatGrid.Instance.komsuList[i].getsag() != "yok")//sağda buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getsag() == CreatGrid.Instance.Buttonlar[kars].name)//sağdaki butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {
                                
                                sayy++;


                            }
                            else
                            {
                                Debug.Log("sağ boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("sağda button yok");
                }




                if (CreatGrid.Instance.komsuList[i].getsol() != "yok")//solda buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getsol() == CreatGrid.Instance.Buttonlar[kars].name)//soldaki butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {

                                sayy++;
                                

                            }
                            else
                            {
                                Debug.Log("sol boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("solda button yok");
                }



                if (CreatGrid.Instance.komsuList[i].getyukari() != "yok")//yukarda buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getyukari() == CreatGrid.Instance.Buttonlar[kars].name)//soldaki butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {

                                sayy++;
                               
                                Debug.Log("yukarısı dolu :)");
                            }
                            else
                            {
                                Debug.Log("yukarısı boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("yukarda komsu yok:)");
                }





                if (CreatGrid.Instance.komsuList[i].getasagi() != "yok")//asagi buton var mı?
                {
                    for (int kars = 0; kars < CreatGrid.Instance.Buttonlar.Count; kars++)
                    {
                        if (CreatGrid.Instance.komsuList[i].getasagi() == CreatGrid.Instance.Buttonlar[kars].name)//aşağı butonlar arasında var mı ismini getir
                        {

                            if (!CreatGrid.Instance.Buttonlar[kars].interactable)
                            {

                                sayy++;
                                
                                Debug.Log("asagi dolu :)");
                            }
                            else
                            {
                                Debug.Log("aşağı boş");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("aşağıda komsu yok:)");

                }

                Debug.Log(sayy);
                if (sayy >= 2)
                {
                    for (int j = 0; j < CreatGrid.Instance.Buttonlar.Count; j++)
                    {
                        CreatGrid.Instance.Buttonlar[j].interactable = true;
                        CreatGrid.Instance.Buttonlar[j].GetComponent<Image>().sprite = normalSprite;
                    }
                }


            }

        }



    }
}











  

