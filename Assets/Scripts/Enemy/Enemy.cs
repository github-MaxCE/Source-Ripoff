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
    
    public Vector3 x;
    public Vector3 y;

    void Awake()
    {
        player = GameObject.Find("Player");
        playermask = player.layer;
        agent = this.GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        Vector3 middle = new Vector3(0, 0, sightRange);
        x = Quaternion.AngleAxis((horizontalfov/2), Vector3.up) * middle;
        y = Quaternion.AngleAxis((verticalfov/2), Vector3.right) * middle;
    }

    private void Update()
    {
        Vector3 playertransform = transform.InverseTransformPoint(player.transform.position);
        float fx = Mathf.Clamp(playertransform.x, -x.x, x.x);
        float fy = Mathf.Clamp(playertransform.y, -y.y, y.y);
        Debug.DrawRay(transform.position, new Vector3(fx, fy, y.z), Color.blue);
        Debug.DrawRay(transform.position, x, Color.red);
        Debug.DrawRay(transform.position, y, Color.green);
    }

    private void cantseeplayer()
    {
        foreach(Transform x in walkpointobject.transform)
        {
            int importance = int.Parse(x.name.Split(new string[] { "->" }, StringSplitOptions.None)[1]);
        }
    }

}