using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemscript : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        // �ڐG�Ώۂ�Player�^�O�ł����H
        if (hit.CompareTag("Player"))
        {
            // ���炩�̏���
            Destroy(gameObject);
        }
    }
}
