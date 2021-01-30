using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    private NavMeshAgent agent;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        

    }

    public void MoveToTarget(Vector3 target)
    {
        agent.destination = target;
    }

    // Start is called before the first frame update
    void Start()
    {
        //��MouseManagerע�᷽��
        //ע�᷽���Ķ����ʽ��������е��¼���ʽ��ͬ��������
        MouseManager.Instance.OnMouseClicked += MoveToTarget;
    }

}
