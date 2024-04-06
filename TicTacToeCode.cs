using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TicTacToeCode : MonoBehaviour
{
    // Start is called before the first frame update
    Boolean check;
    int pluxone;
    public Text btn1=null;
    public Text btn2 =null;
    public Text btn3 =null;
    public Text btn4 =null; 
    public Text btn5 =null;
    public Text btn6 =null;
    public Text btn7 =null;
    public Text btn8 =null;
    public Text btn9 =null;
    public Text btnxtart =null;
    public Text btnrexet =null;
    public Text mxgfeedback= null;
    public Text playerX;
    public Text playerO;
    public void Xcore()
    {
        if (btn1.text=="X" && btn2.text == "X" && btn3.text == "X"  )
        {
            btn1.color = Color.red;
            btn2.color = Color.red;
            btn3.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone= Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone+1);

        }
        if (btn4.text == "X" && btn5.text == "X" && btn6.text == "X")
        {
            btn4.color = Color.red;
            btn5.color = Color.red;
            btn6.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone = Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone+1);

        }
        if (btn7.text == "X" && btn8.text == "X" && btn9.text == "X")
        {
            btn7.color = Color.red;
            btn8.color = Color.red;
            btn9.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone = Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone + 1);

        }
        if (btn1.text == "X" && btn5.text == "X" && btn9.text == "X")
        {
            btn1.color = Color.red;
            btn5.color = Color.red;
            btn9.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone = Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone +1);

        }
        if (btn3.text == "X" && btn5.text == "X" && btn7.text == "X")
        {
            btn3.color = Color.red;
            btn5.color = Color.red;
            btn7.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone = Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone + 1);

        }
        if (btn1.text == "X" && btn4.text == "X" && btn7.text == "X")
        {
            btn1.color = Color.red;
            btn4.color = Color.red;
            btn7.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone = Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone+1);

        }
        if (btn2.text == "X" && btn5.text == "X" && btn8.text == "X" )
        {
            btn2.color = Color.red;
            btn5.color = Color.red;
            btn8.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone = Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone + 1);

        }
        if (btn3.text == "X" && btn6.text == "X" && btn9.text == "X")
        {
            btn3.color = Color.red;
            btn6.color = Color.red;
            btn9.color = Color.red;
            mxgfeedback.text = "X Winner";
            pluxone = Convert.ToInt32(playerX.text);
            playerX.text = Convert.ToString(pluxone + 1);

        }
        // Player O
        if (btn1.text == "O" && btn2.text == "O" && btn3.text == "O")
        {
            btn1.color = Color.red;
            btn2.color = Color.red;
            btn3.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }
        if (btn4.text == "O" && btn5.text == "O" && btn6.text == "O")
        {
            btn4.color = Color.red;
            btn5.color = Color.red;
            btn6.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }
        if (btn7.text == "O" && btn8.text == "O" && btn9.text == "O")
        {
            btn7.color = Color.red;
            btn8.color = Color.red;
            btn9.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }
        if (btn1.text == "O" && btn5.text == "O" && btn9.text == "O")
        {
            btn1.color = Color.red;
            btn5.color = Color.red;
            btn9.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }
        if (btn3.text == "O" && btn5.text == "O" && btn7.text == "O")
        {
            btn3.color = Color.red;
            btn5.color = Color.red;
            btn7.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }
        if (btn1.text == "O" && btn4.text == "O" && btn7.text == "O")
        {
            btn1.color = Color.red;
            btn4.color = Color.red;
            btn7.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }
        if (btn2.text == "O" && btn5.text == "O" && btn8.text == "O")
        {
            btn2.color = Color.red;
            btn5.color = Color.red;
            btn8.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }
        if (btn3.text == "O" && btn6.text == "O" && btn9.text == "O")
        {
            btn3.color = Color.red;
            btn6.color = Color.red;
            btn9.color = Color.red;
            mxgfeedback.text = "O Winner";
            pluxone = Convert.ToInt32(playerO.text);
            playerO.text = Convert.ToString(pluxone + 1);

        }


    }
    public void btn1_Click()
    {
        if (check == false)
        {
            btn1.text = "X";
            check = true;
        }
        else
        {
            btn1.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn2_Click()
    {
        if (check == false)
        {
            btn2.text = "X";
            check = true;
        }
        else
        {
            btn2.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn3_Click()
    {
        if (check == false)
        {
            btn3.text = "X";
            check = true;
        }
        else
        {
            btn3.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn4_Click()
    {
        if (check == false)
        {
            btn4.text = "X";
            check = true;
        }
        else
        {
            btn4.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn5_Click()
    {
        if (check == false)
        {
            btn5.text = "X";
            check = true;
        }
        else
        {
            btn5.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn6_Click()
    {
        if (check == false)
        {
            btn6.text = "X";
            check = true;
        }
        else
        {
            btn6.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn7_Click()
    {
        if (check == false)
        {
            btn7.text = "X";
            check = true;
        }
        else
        {
            btn7.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn8_Click()
    {
        if (check == false)
        {
            btn8.text = "X";
            check = true;
        }
        else
        {
            btn8.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn9_Click()
    {
        if (check == false)
        {
            btn4.text = "X";
            check = true;
        }
        else
        {
            btn9.text = "O";
            check = false;
        }
        Xcore();
    }
    public void btn_Rexet()
    {
        btn1.text = "";
        btn2.text = "";
        btn3.text = "";
        btn4.text = "";
        btn5.text = "";
        btn6.text = "";
        btn7.text = "";
        btn8.text = "";
        btn9.text = "";
        mxgfeedback.text = "Tic Tac Te";
        btn1.color = Color.black;
        btn2.color= Color.black;
        btn3.color = Color.black;
        btn4.color = Color.black;
        btn5.color = Color.black;
        btn6.color = Color.black;
        btn7.color = Color.black;
        btn8.color =  Color.black;
        btn9.color = Color.black;


    }
    public void xtartgame()
    {
        btn_Rexet();
        playerO.text = "";
        playerX.text = "";
        mxgfeedback.text = "Tic Tac Te";
    }
}
