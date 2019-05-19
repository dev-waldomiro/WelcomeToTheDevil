using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObstacleControl : MonoBehaviour
{
    [SerializeField] float moveSpeed = -5f;
    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        
        if(transform.position.x < -13f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.name.Equals("trex"))
        {
            SceneManager.LoadScene("MenuFinal");
        }
    }
}
