using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Boss boss = new Boss();
    
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 17, 53, 97, 5, 32 };
      for(int i=0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
      for(int i = 4; i > -1; i--)
        {
            Debug.Log(array[i]);
        }
     for(int i = 0; i <= 11; i++)
        {
            boss.Magic();
        }
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
    }

        // Update is called once per frame
        void Update()
        {

        }
    
    
}
public class Boss
{
    private int hp = 100;        // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。のこりMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

}