using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(horizontalMovement, 0f, verticalMovement);

        
    }
}
