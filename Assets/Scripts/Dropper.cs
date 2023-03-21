using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeBeforeFall = 3f;
    private Rigidbody DropperRB;


    private void Start()
    {
        DropperRB = GetComponent<Rigidbody>();
        DropperRB.useGravity = false;
    }
    private void Update()
    {
        if (Time.time > timeBeforeFall)
        {
            DropperRB.useGravity = true;
        }
    }
}
