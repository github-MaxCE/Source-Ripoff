using UnityEngine;
using UnityEngine.Events;
public class Trigger : MonoBehaviour
{
    public UnityEvent Triggeraction;

    void OnTriggerEnter(Collider Player)
    {
        if(Player.tag == "Player")
        {
            Triggeraction.Invoke();
        }
    }
}