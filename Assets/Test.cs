﻿using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;    //体力
    private int power = 25; //攻撃力
    public int mp = 53; //MP

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else
        {
                Debug.Log("MPが足りないため魔法が使えない");
        }


    }
}


public class Test : MonoBehaviour
{
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
        


        
        //配列初期化
        int[] array = { 10, 20, 30, 40, 50 };

        //配列すべてを順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //配列すべてを逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
    

    // Update is called once per frame
    void Update ()
    {

    }
}

