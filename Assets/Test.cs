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
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
    }

        // Update is called once per frame
        void Update()
        {

        }
    
    
}
public class Boss
{
    private int hp = 100;        // �̗�
    private int power = 25; // �U����
    private int mp = 53;

        // �U���p�̊֐�
        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }

        // �h��p�̊֐�
        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            // �c��hp�����炷
            this.hp -= damage;
        }
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�̂���MP��" + mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }

}