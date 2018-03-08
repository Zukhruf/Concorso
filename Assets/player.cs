using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public GameObject humvee, mtvvr, tank, tiger;
    public GameObject[] Path;
    public GameObject dadu, dadu2;
    int humveePos, mtvvrPos, tankPos, tigerPos, counterPos, targetPos, dadu1Value, dadu2Value, mundur, power, powerx;
    bool humveeMove, mtvvrMove, tankMove, tigerMove;
    // Use this for initialization
    void Start() {
        humveePos = 0; mtvvrPos = 0; tankPos = 0; tigerPos = 0; mundur = 0; power = 0; powerx = 0;
        humveeMove = false; mtvvrMove = false; tankMove = false; tigerMove = false;
    }

    // Update is called once per frame
    void Update() {
        if (humveeMove) {
            if (mundur == 1)
            {
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1Hx();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2Hx();
                }
                else
                {
                    card3Hx();
                }
            }
            else
            {
                humvee.transform.position = Vector3.MoveTowards(humvee.transform.position, Path[humveePos].transform.position, 5.3f);
                //			getCard ();
                if (Vector3.Distance(humvee.transform.position, Path[humveePos].transform.position) < 0.1f)
                {
                    if (counterPos < targetPos)
                    {
                        counterPos++;
                        humveePos++;
                        mundur = 0;
                    }
                    else
                    {
                        humveeMove = false;
                        if (humveePos >= Path.Length - 1)
                        {
                            Debug.Log("Humvee wins!");
                        }
                    }
                }
            }
        }
        else if (mtvvrMove) {
            if (mundur == 1)
            {
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1Mx();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2Mx();
                }
                else
                {
                    card3Mx();
                }
            }
            else
            {
                mtvvr.transform.position = Vector3.MoveTowards(mtvvr.transform.position, Path[mtvvrPos].transform.position, 5.3f);
                //			getCard ();
                if (Vector3.Distance(mtvvr.transform.position, Path[mtvvrPos].transform.position) < 0.1f)
                {
                    if (counterPos < targetPos)
                    {
                        counterPos++;
                        mtvvrPos++;
                        mundur = 0;
                    }
                    else
                    {
                        mtvvrMove = false;
                        if (mtvvrPos >= Path.Length - 1)
                        {
                            Debug.Log("Mtvvr wins!");
                        }
                    }
                }
            }
        }
        else if (tankMove) {
            if (mundur == 1)
            {
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1Tax();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2Tax();
                }
                else
                {
                    card3Tax();
                }
            }
            else
            {
                tank.transform.position = Vector3.MoveTowards(tank.transform.position, Path[tankPos].transform.position, 5.3f);
                //			getCard ();
                if (Vector3.Distance(tank.transform.position, Path[tankPos].transform.position) < 0.1f)
                {
                    if (counterPos < targetPos)
                    {
                        counterPos++;
                        tankPos++;
                        mundur = 0;
                    }
                    else
                    {
                        tankMove = false;
                        if (tankPos >= Path.Length - 1)
                        {
                            Debug.Log("Tank wins!");
                        }
                    }
                }
            }
        }

        else if (tigerMove) {
            if (mundur == 1) {
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1Tx();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2Tx();
                }
                else
                {
                    card3Tx();
                }
            } else
            {
                tiger.transform.position = Vector3.MoveTowards(tiger.transform.position, Path[tigerPos].transform.position, 5.3f);
                //			getCard ();
                if (Vector3.Distance(tiger.transform.position, Path[tigerPos].transform.position) < 0.1f)
                {
                    if (counterPos < targetPos)
                    {
                        counterPos++;
                        tigerPos++;
                        mundur = 0;
                    }
                    else
                    {
                        tigerMove = false;
                        if (tigerPos >= Path.Length - 1)
                        {
                            Debug.Log("Tiger wins!");
                        }
                    }
                }
            }
        }
    }


    void card1Hx()
    {
        humvee.transform.position = Vector3.MoveTowards(humvee.transform.position, Path[humveePos - 7].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(humvee.transform.position, Path[humveePos - 7].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                humveePos = humveePos - 7;
            }
            else
            {
                humveeMove = false;
                if (humveePos >= Path.Length - 1)
                {
                    Debug.Log("Humvee wins!");
                }
            }
        }
    }
    void card2Hx()
    {
        humvee.transform.position = Vector3.MoveTowards(humvee.transform.position, Path[humveePos - 9].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(humvee.transform.position, Path[humveePos - 9].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                humveePos = humveePos - 9;
            }
            else
            {
                humveeMove = false;
                if (humveePos >= Path.Length - 1)
                {
                    Debug.Log("Humvee wins!");
                }
            }
        }

    }
    void card3Hx()
    {
        humvee.transform.position = Vector3.MoveTowards(humvee.transform.position, Path[humveePos - 12].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(humvee.transform.position, Path[humveePos - 12].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                humveePos = humveePos - 12;
            }
            else
            {
                humveeMove = false;
                if (humveePos >= Path.Length - 1)
                {
                    Debug.Log("Humvee wins!");
                }
            }
        }
    }

    void card1Mx()
    {
        mtvvr.transform.position = Vector3.MoveTowards(mtvvr.transform.position, Path[mtvvrPos - 7].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(mtvvr.transform.position, Path[mtvvrPos - 7].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                mtvvrPos = mtvvrPos - 7;
            }
            else
            {
                tankMove = false;
                if (mtvvrPos >= Path.Length - 1)
                {
                    Debug.Log("Mtvvr wins!");
                }
            }
        }
    }
    void card2Mx()
    {
        mtvvr.transform.position = Vector3.MoveTowards(mtvvr.transform.position, Path[mtvvrPos - 9].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(mtvvr.transform.position, Path[mtvvrPos - 9].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                mtvvrPos = mtvvrPos - 9;
            }
            else
            {
                tankMove = false;
                if (mtvvrPos >= Path.Length - 1)
                {
                    Debug.Log("Mtvvr wins!");
                }
            }
        }

    }
    void card3Mx()
    {
        mtvvr.transform.position = Vector3.MoveTowards(mtvvr.transform.position, Path[mtvvrPos - 12].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(mtvvr.transform.position, Path[mtvvrPos - 12].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                mtvvrPos = mtvvrPos - 12;
            }
            else
            {
                tankMove = false;
                if (mtvvrPos >= Path.Length - 1)
                {
                    Debug.Log("Mtvvr wins!");
                }
            }
        }
    }

    void card1Tax()
    {
        tank.transform.position = Vector3.MoveTowards(tank.transform.position, Path[tankPos - 7].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(tank.transform.position, Path[tankPos - 7].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                tankPos = tankPos - 7;
            }
            else
            {
                tankMove = false;
                if (tankPos >= Path.Length - 1)
                {
                    Debug.Log("Tank wins!");
                }
            }
        }
    }
    void card2Tax()
    {
        tank.transform.position = Vector3.MoveTowards(tank.transform.position, Path[tankPos - 9].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(tank.transform.position, Path[tankPos - 9].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                tankPos = tankPos - 9;
            }
            else
            {
                tankMove = false;
                if (tankPos >= Path.Length - 1)
                {
                    Debug.Log("Tank wins!");
                }
            }
        }

    }
    void card3Tax()
    {
        tank.transform.position = Vector3.MoveTowards(tank.transform.position, Path[tankPos - 12].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(tank.transform.position, Path[tankPos - 12].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                tankPos = tankPos - 12;
            }
            else
            {
                tankMove = false;
                if (tankPos >= Path.Length - 1)
                {
                    Debug.Log("Tank wins!");
                }
            }
        }
    } 

    void card1Tx()
    {
        tiger.transform.position = Vector3.MoveTowards(tiger.transform.position, Path[tigerPos-7].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(tiger.transform.position, Path[tigerPos-7].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                tigerPos = tigerPos - 7;
            }
            else
            {
                tigerMove = false;
                if (tigerPos >= Path.Length - 1)
                {
                    Debug.Log("tiger wins!");
                }
            }
        }
    }
    void card2Tx()
    {
        tiger.transform.position = Vector3.MoveTowards(tiger.transform.position, Path[tigerPos - 9].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(tiger.transform.position, Path[tigerPos - 9].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                tigerPos = tigerPos - 9;
            }
            else
            {
                tigerMove = false;
                if (tigerPos >= Path.Length - 1)
                {
                    Debug.Log("tiger wins!");
                }
            }
        }
 
    }
    void card3Tx()
    {
        tiger.transform.position = Vector3.MoveTowards(tiger.transform.position, Path[tigerPos - 12].transform.position, 5.3f);
        //			getCard ();
        if (Vector3.Distance(tiger.transform.position, Path[tigerPos - 12].transform.position) < 0.1f)
        {
            if (counterPos < targetPos)
            {
                counterPos++;
                tigerPos = tigerPos - 12;
            }
            else
            {
                tigerMove = false;
                if (tigerPos >= Path.Length - 1)
                {
                    Debug.Log("tiger wins!");
                }
            }
        }
    }

    void card1H()
    {
        mundur = 1;
        humveeMove = true;
        targetPos = 2;
        humveePos = humveePos - 7;
        counterPos = 1;
    }
    void card2H()
    {
        mundur = 1;
        humveeMove = true;
        targetPos = 2;
        humveePos = humveePos - 9;
        counterPos = 1;
    }
    void card3H()
    {
        mundur = 1;
        humveeMove = true;
        targetPos = 2;
        humveePos = humveePos - 12;
        counterPos = 1;
    }
    void card4H()
    {
        humveeMove = true;
        targetPos = 4;
        humveePos++;
        counterPos = 1;

    }
    void card5H()
    {
        humveeMove = true;
        targetPos = 6;
        humveePos++;
        counterPos = 1;

    }
    void card6H()
    {
        humveeMove = true;
        targetPos = 9;
        humveePos++;
        counterPos = 1;

    }

    void card1M()
    {
        mundur = 1;
        mtvvrMove = true;
        targetPos = 2;
        mtvvrPos = mtvvrPos - 7;
        counterPos = 1;
    }
    void card2M()
    {
        mundur = 1;
        mtvvrMove = true;
        targetPos = 2;
        mtvvrPos = mtvvrPos - 9;
        counterPos = 1;
    }
    void card3M()
    {
        mundur = 1;
        mtvvrMove = true;
        targetPos = 2;
        mtvvrPos = mtvvrPos - 12;
        counterPos = 1;
    }
    void card4M()
    {
        mtvvrMove = true;
        targetPos = 4;
        mtvvrPos++;
        counterPos = 1;

    }
    void card5M()
    {
        mtvvrMove = true;
        targetPos = 6;
        mtvvrPos++;
        counterPos = 1;

    }
    void card6M()
    {
        mtvvrMove = true;
        targetPos = 9;
        mtvvrPos++;
        counterPos = 1;

    }

    void card1Ta()
    {
        mundur = 1;
        tankMove = true;
        targetPos = 2;
        tankPos = tankPos - 7;
        counterPos = 1;
    }
    void card2Ta()
    {
        mundur = 1;
        tankMove = true;
        targetPos = 2;
        tankPos = tankPos - 9;
        counterPos = 1;
    }
    void card3Ta()
    {
        mundur = 1;
        tankMove = true;
        targetPos = 2;
        tankPos = tankPos - 12;
        counterPos = 1;
    }
    void card4Ta()
    {
        tankMove = true;
        targetPos = 4;
        tankPos++;
        counterPos = 1;

    }
    void card5Ta()
    {
        tankMove = true;
        targetPos = 6;
        tankPos++;
        counterPos = 1;

    }
    void card6Ta()
    {
        tankMove = true;
        targetPos = 9;
        tankPos++;
        counterPos = 1;

    }

    void card1T() {
        mundur = 1;
        tigerMove = true;
        targetPos = 2;
        tigerPos = tigerPos - 7;
        counterPos = 1;
    }
    void card2T()
    {
    mundur = 1;
    tigerMove = true;
    targetPos = 2;
    tigerPos = tigerPos - 9;
    counterPos = 1;
}
    void card3T()
    {
    mundur = 1;
    tigerMove = true;
    targetPos = 2;
    tigerPos = tigerPos - 12;
    counterPos = 1;
}
    void card4T()
    {
        tigerMove = true;
        targetPos = 4;
            tigerPos++;
            counterPos = 1;
      
    }
    void card5T()
    {
        tigerMove = true;
        targetPos = 6;
            tigerPos++;
            counterPos = 1;
       
    }
    void card6T()
    {
        tigerMove = true;
        targetPos = 9;
            tigerPos++;
            counterPos = 1;
         
    }

    void getCardHumvee()
    {

        if (humveePos % 3 == 0)
        {
            if (humveePos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1H();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2H();
                }
                else if (power == 6)
                {
                    card3H();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4H();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5H();
                }
                else
                {
                    card6H();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4H();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5H();
                    }
                    else if (power == 6)
                    {
                        card6H();
                    }
                }
            }
        }
        else if ((humveePos - 2) % 3 == 0)
        {
            if (humveePos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1H();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2H();
                }
                else if (power == 6)
                {
                    card3H();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4H();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5H();
                }
                else
                {
                    card6H();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4H();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5H();
                    }
                    else if (power == 6)
                    {
                        card6H();
                    }
                }
            }
        }
        else
        {

        }
    }

        void getCardMtvvr()
    {

        if (mtvvrPos % 3 == 0)
        {
            if (mtvvrPos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1M();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2M();
                }
                else if (power == 6)
                {
                    card3M();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4M();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5M();
                }
                else
                {
                    card6M();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4M();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5M();
                    }
                    else if (power == 6)
                    {
                        card6M();
                    }
                }
            }
        }
        else if ((mtvvrPos - 2) % 3 == 0)
        {
            if (mtvvrPos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1M();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2M();
                }
                else if (power == 6)
                {
                    card3M();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4M();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5M();
                }
                else
                {
                    card6M();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4M();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5M();
                    }
                    else if (power == 6)
                    {
                        card6M();
                    }
                }
            }
        }
        else
        {

        }
    }

    void getCardTank()
    {

        if (tankPos % 3 == 0)
        {
            if (tankPos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1Ta();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2Ta();
                }
                else if (power == 6)
                {
                    card3Ta();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4Ta();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5Ta();
                }
                else
                {
                    card6Ta();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4Ta();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5Ta();
                    }
                    else if (power == 6)
                    {
                        card6Ta();
                    }
                }
            }
        }
        else if ((tankPos - 2) % 3 == 0)
        {
            if (tankPos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1Ta();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2Ta();
                }
                else if (power == 6)
                {
                    card3Ta();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4Ta();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5Ta();
                }
                else
                {
                    card6Ta();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4Ta();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5Ta();
                    }
                    else if (power == 6)
                    {
                        card6Ta();
                    }
                }
            }
        }
        else
        {

        }
    }

    void getCardTiger()
    {

        if (tigerPos % 3 == 0)
        {
            if (tigerPos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1T();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2T();
                }
                else if (power == 6)
                {
                    card3T();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4T();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5T();
                }
                else
                {
                    card6T();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4T();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5T();
                    }
                    else if (power == 6)
                    {
                        card6T();
                    }
                }
            }
        } 
        else if ((tigerPos-2) % 3 == 0)
        {
            if (tigerPos >= 10)
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 12);
                if ((power == 0) || (power == 1) || (power == 2))
                {
                    card1T();
                }
                else if ((power == 3) || (power == 4) || (power == 5))
                {
                    card2T();
                }
                else if (power == 6)
                {
                    card3T();
                }
                else if ((power == 7) || (power == 8))
                {
                    card4T();
                }
                else if ((power == 9) || (power == 10))
                {
                    card5T();
                }
                else
                {
                    card6T();
                }
            }
            else
            {
                System.Random ran = new System.Random();
                int power = ran.Next(0, 7);
                {
                    if ((power == 0) || (power == 1) || (power == 2))
                    {
                        card4T();
                    }
                    else if ((power == 3) || (power == 4) || (power == 5))
                    {
                        card5T();
                    }
                    else if (power == 6)
                    {
                        card6T();
                    }
                }
            }
        }
        else
        {

        }
    }

    /*Contoh kalau satu dadu*/
    void ExecHumveeMove()
    {
        humveeMove = true;
        targetPos = dadu.GetComponent<dadu>().angkaDadu + dadu2.GetComponent<dadu2>().angkaDadu2;
            humveePos++;
            counterPos = 1;
    }

    void ExecMtvvrMove(){
		mtvvrMove = true;
		targetPos = dadu.GetComponent<dadu> ().angkaDadu + dadu2.GetComponent<dadu2>().angkaDadu2;
			mtvvrPos++;
			counterPos = 1;
	}
	void ExecTankMove(){
		tankMove = true;
		targetPos = dadu.GetComponent<dadu> ().angkaDadu + dadu2.GetComponent<dadu2>().angkaDadu2;
			tankPos++;
			counterPos = 1;
	}
	void ExecTigerMove(){              
            tigerMove = true;
            targetPos = dadu.GetComponent<dadu>().angkaDadu + dadu2.GetComponent<dadu2>().angkaDadu2;
                tigerPos++;
                counterPos = 1;

        }
	
	void OnGUI(){
		if (GUI.Button (new Rect (10, 45, 100, 30), "humvee move!")) {
		ExecHumveeMove();
            getCardHumvee();
            mundur = 0;                                                                   
		}
		if (GUI.Button (new Rect (10, 85, 100, 30), "mtvvr move!")) {
			ExecMtvvrMove();
            getCardMtvvr();
            mundur = 0;
		}
		if (GUI.Button (new Rect (10, 125, 100, 30), "tank move")) {
		    ExecTankMove();
            getCardTank();
            mundur = 0;
		}
		if (GUI.Button (new Rect (10, 165, 100, 30), "tiger move")) {
		ExecTigerMove();
        getCardTiger();
            mundur = 0;
        }
		if(GUI.Button(new Rect(1150, 10, 100, 30), "Mute!")){
			AudioListener.volume = 1 - AudioListener.volume;
		}
		if(GUI.Button(new Rect(1150, 45, 100, 30), "Quit")){
			Application.Quit ();
		}
	}
}
