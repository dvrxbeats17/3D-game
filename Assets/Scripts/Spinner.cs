using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _speedOfSpinner = 15f;
    private void Update()
    {
        transform.Rotate(0f, _speedOfSpinner * Time.deltaTime, 0f);
    }
}
