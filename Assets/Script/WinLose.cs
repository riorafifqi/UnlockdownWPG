﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    GameLogic GL;
    // Win
    public Card healthWin;
    public Card mentalWin;
    public Card moneyWin;

    // Lose
    public Card healthLose;
    public Card mentalLose;
    public Card moneyLose;

    void Awake()
    {
        GL = GameObject.Find("GameManager").GetComponent<GameLogic>();
    }

    void Update()
    {
        if (GL.month_count >= 36)
        {
            Win();
        }
        else if (GameLogic.Health <= 0 || GameLogic.Mental <= 0 || GameLogic.Money <= 0)
        {
            Lose();
        }
    }

    void Win()
    {
        Debug.Log("You Win");
        if (GameLogic.Health > GameLogic.Money && GameLogic.Health > GameLogic.Mental)
        {
            GL.currentCard = healthWin;
            GL.CardSpriteRenderer.sprite = healthWin.sprite;
            GL.leftdialogue = healthWin.leftDialogue;
            GL.rightdialogue = healthWin.RightDialogue;
            GL.carddialoguetext.text = healthWin.cardDialogue;
        }
        else if (GameLogic.Money > GameLogic.Health && GameLogic.Money > GameLogic.Mental)
        {
            GL.currentCard = moneyWin;
            GL.CardSpriteRenderer.sprite = moneyWin.sprite;
            GL.leftdialogue = moneyWin.leftDialogue;
            GL.rightdialogue = moneyWin.RightDialogue;
            GL.carddialoguetext.text = moneyWin.cardDialogue;
        }
        else if (GameLogic.Mental > GameLogic.Health && GameLogic.Mental > GameLogic.Money)
        {
            GL.currentCard = mentalWin;
            GL.CardSpriteRenderer.sprite = mentalWin.sprite;
            GL.leftdialogue = mentalWin.leftDialogue;
            GL.rightdialogue = mentalWin.RightDialogue;
            GL.carddialoguetext.text = mentalWin.cardDialogue;
        }
    }

    void Lose()
    {
        if (GameLogic.iskarmaGood) // Karma Good Impact
        {
            GameLogic.Health += 2;
            GameLogic.Mental += 20;
            GameLogic.Money += 20;
            GameLogic.iskarmaGood = false;
        }
        else
        {
            Debug.Log("You Lose");
            if (GameLogic.Mental <= 0)
            {
                GL.currentCard = mentalLose;
                GL.CardSpriteRenderer.sprite = mentalLose.sprite;
                GL.leftdialogue = mentalLose.leftDialogue;
                GL.rightdialogue = mentalLose.RightDialogue;
                GL.carddialoguetext.text = mentalLose.cardDialogue;
            }
            else if (GameLogic.Health <= 0)
            {
                GL.currentCard = healthLose;
                GL.CardSpriteRenderer.sprite = healthLose.sprite;
                GL.leftdialogue = healthLose.leftDialogue;
                GL.rightdialogue = healthLose.RightDialogue;
                GL.carddialoguetext.text = healthLose.cardDialogue;
            }
            else if (GameLogic.Health <= 0)
            {
                GL.currentCard = healthLose;
                GL.CardSpriteRenderer.sprite = healthLose.sprite;
                GL.leftdialogue = healthLose.leftDialogue;
                GL.rightdialogue = healthLose.RightDialogue;
                GL.carddialoguetext.text = healthLose.cardDialogue;
            }
        }
    }
}
