using System;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float verticalfov = -80;
    public float horizontalfov = 150;

    public GameObject walkpointobject;

    public NavMeshData navMeshData;
    private NavMeshAgent agent;

    private GameObject player;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //States
    private LayerMask playermask;
    public float sightRange = 33f;
    public float instantsightRange = 16.5f;
    public bool canhearplayer;

    public bool canseeplayer;
    
    private Vector3 up;
    private Vector3 down;
    private Vector3 left;
    private Vector3 right;
    private Vector3 middle;

    void Awake()
    {

        player = GameObject.Find("Player");
        playermask = player.layer;
        agent = this.GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        Vector3 lmiddle = middle = new Vector3(transform.position.x, transform.position.y, transform.position.z + sightRange);
        up = Quaternion.Euler(-(verticalfov / 2), 0, 0) * lmiddle;
        down = Quaternion.Euler((verticalfov / 2), 0, 0) * lmiddle;
        left = Quaternion.Euler(0, -(horizontalfov / 2), 0) * lmiddle;
        right = Quaternion.Euler(0, (horizontalfov / 2), 0) * lmiddle;
 
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, up, Color.red);
        Debug.DrawRay(transform.position, down, Color.yellow);
        Debug.DrawRay(transform.position, left, Color.blue);
        Debug.DrawRay(transform.position, right, Color.green);
        
    }

    private void cantseeplayer()
    {
        foreach(Transform x in walkpointobject.transform)
        {
            int importance = int.Parse(x.name.Split(new string[] { "->" }, StringSplitOptions.None)[1]);
        }
    }

}