using UnityEngine;

public class Musuh_Hard : MonoBehaviour
{
    public float speed = 0.8f;
    public float Range = 3;

    private float startY;
    int dir = 1;

    void Start()
    {
        startY = transform.position.y;
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime * dir);
        if(transform.position.y < startY || transform.position.y > startY + Range){
            dir *= -1;
        }
    }
}
