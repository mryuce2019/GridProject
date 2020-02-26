using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Komsular : MonoBehaviour
{
    Button bntt;
    string sag;
    string sol;
    string asagi;
    string yukari;
    

    public Komsular(Button bntt,string sag,string sol,string asagi,string yukari)
    {
        this.bntt = bntt;
        this.sag = sag;
        this.sol = sol;
        this.asagi = asagi;
        this.yukari = yukari;

   

    }


    public Button getBntt()
    {

        return bntt;
    }

    public string getsag()
    {

        return sag;
    }

    public string getsol()
    {

        return sol;
    }
    public string getasagi()
    {

        return asagi;
    }
    public string getyukari()
    {

        return yukari;
    }
   
}
