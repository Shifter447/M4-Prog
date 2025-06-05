using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float speed = 5f;
    public float overigetijd = 60f;
    public int score = 0;
    

    void Update()
    {
        
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(Horizontal, 0, Vertical);

        transform.Translate(direction * speed * Time.deltaTime);

        overigetijd -= Time.deltaTime;

        
        if (overigetijd <= 0)
        {
            Debug.Log("Game over! Eindscore: " + score);
            enabled = false; 
            return;      
        }

        Debug.Log("Tijd over: " + Mathf.CeilToInt(overigetijd) + "s | Score: " + score);

    }
   
    void OnTriggerEnter(Collider other)
    {

        //Check of je een coin hebt geraakt.
        if (other.CompareTag("Coin"))
        {
            score += 10;

            Debug.Log("Coin gepakt! +10 punten");

            Destroy(other.gameObject);

        }
    }
}