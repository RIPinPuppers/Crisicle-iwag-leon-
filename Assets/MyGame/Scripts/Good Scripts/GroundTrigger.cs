using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    private ObjectGod objectGod;

    private void Start()
    {
        objectGod = GameObject.FindGameObjectWithTag(GlobalVariables.manager).GetComponent<ObjectGod>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        objectGod.SpawnLayer();
    }
}
