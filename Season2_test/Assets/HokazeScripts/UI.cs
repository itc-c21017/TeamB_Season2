using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text GomiText;
    public Text GoalText;
    public Text KeikokuText;
    public Slider HPslider;
    static int i = 0;
    int maxHp = 100;
    float a = 100;
    float j = 0;
    static int c = 0;
    int d = 0;

    // Start is called before the first frame update
    public void Start()
    {
        // �[�d�ʂ�MAX����X�^�[�g
        HPslider.value = 1;

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    public void Update()
    {
        // ���ݗʂ��X�V
        int score = Ascore();
        GomiText.text = "���ݗ� : " + i + "�_";

        // �S�~���X�^�b�N���Ă��鐔��2�ȏ�̎�
        if (i >= 2)
        {
            KeikokuText.text = "�S�~���̂Ă悤";

        // �S�~���X�^�b�N���Ă��鐔��1�ȏ�̎�
        }else if(i <= 1)
        {
            KeikokuText.text = " ";
        }

        // �[�d�ʂ����炷
        a -= Time.deltaTime;
        j = Mathf.Floor(a);
        HPslider.value = j / maxHp;

        // �|����
        int Clear = AreaClear();
        GoalText.text = "�|���� : " + d + "%";

    }

    public void OnCollisionEnter(Collision collision)
    {
       
    }

    public void OnTriggerEnter(Collider other)
    {
        // �S�~�^�O�ɐڐG�����Ƃ�
        if (other.gameObject.tag == "Gomi")
        {
            // ���ݗʂ�1������
            i += 1;
        }

        // �����|�C���g�^�O�ɐڐG������
        else if (other.gameObject.tag == "ShoriPoint")
        {
            // �i�����̌v�Z
            c = c + i;
            c = c * 5;
            
            // �S�~�X�^�b�N��������
            i = 0;

            // �i����
            d = d + c;

            // �i�����̌v�Z��������
            c = 0;
            
            
        }



        
    }

    // �ȉ��͊֐�
    public static int Ascore()
    {
        return (int)i;
    }

    public static int AreaClear()
    {
        return (int)c;
    }
}
