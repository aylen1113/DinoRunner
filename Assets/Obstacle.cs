using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 5f;
    private void OnBecameInvisible()
    {
        ObjectPool.Instance.ReturnObjectToPool(gameObject);
    }

    void Update()
    {
        // Move the obstacle left over time
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
