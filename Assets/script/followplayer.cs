using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform target; // �^�[�Q�b�g�ւ̎Q��
    private Vector3 offset; // ���΍��W
    void Start()
    {
        //�������g��target�Ƃ̑��΋��������߂�
        offset = GetComponent<Transform>().position -target.position;
    }
    void Update()
    {
       GetComponent<Transform>().position =target.position + offset;
    }
}
