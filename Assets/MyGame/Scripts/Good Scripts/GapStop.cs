using UnityEngine;
using UnityEngine.SceneManagement;

public class GapStop : MonoBehaviour
{
    public GameObject fuckingCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);

        if (collision.CompareTag(GlobalVariables.icicle))
        {
            collision.GetComponentInParent<Rigidbody2D>().simulated = false;
            collision.GetComponent<BoxCollider2D>().enabled = false;

            fuckingCollider.SetActive(true);
        }
        else if (collision.CompareTag(GlobalVariables.player))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
