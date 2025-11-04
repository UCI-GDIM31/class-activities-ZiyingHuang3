using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _cat;
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _cat.position,_speed* Time.deltaTime);
    }
    public void Chasecat(Transform player)
    { 
        enabled = true;
        _cat = player;
    }
    public void Nochasecat()
    {
        enabled= false;
    }
}
