using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "ダメージを与えた");
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
        if (this.mp >= 5)
        {
        this.mp -= 5;
        Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }
}

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        int[] array = { 30, 20, 10, 50, 15 };

        //配列の各要素を順番に表示
        for(int i=0; i<5; i++)
        {
            Debug.Log(array[i]);
        }
        
        //各要素の値を逆順に表示
        for(int i=4; i>=0; i--)
        {
            Debug.Log(array[i]);
        }

        //bossクラスの変数を宣言してインスタンスを代入
        Boss magicboss = new Boss();

        //魔法攻撃用の関数を呼び出す
        magicboss.Magic();

        //魔法攻撃用の関数を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            magicboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}