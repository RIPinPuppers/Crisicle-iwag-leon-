﻿using UnityEngine;

public class ObjectGod : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject icicle;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject fuckingCollider;
    [SerializeField] private GameObject gapObject;
    [SerializeField] private float gap = 2;
    [SerializeField] private float yOffsetGround, groundSize, yOffsetIcicle;
    [SerializeField] private ObjectMovement objectMovement;

    private GapStop gapStop;

    private void Start()
    {
        SpawnLayer();
    }
    
    public void SpawnLayer()
    {
        GameObject tempGround = Instantiate(
            ground,
            new Vector3(player.transform.position.x + groundSize + gap, player.transform.position.y - yOffsetGround, 0),
            Quaternion.identity);
        objectMovement.MovingObjects.Add(tempGround);

        GameObject tempIcicle = Instantiate(
            icicle,
            new Vector3(player.transform.position.x + groundSize / 2 + gap / 2, player.transform.position.y + yOffsetIcicle, 0),
            Quaternion.identity);
        objectMovement.MovingObjects.Add(tempIcicle);

        GameObject tempGap = Instantiate(
            gapObject,
            new Vector3(player.transform.position.x + groundSize / 2 + gap / 2, player.transform.position.y - yOffsetGround, 0),
            Quaternion.identity);
        objectMovement.MovingObjects.Add(tempGap);

        GameObject tempFuckingCollider = Instantiate(
            fuckingCollider,
            new Vector3(player.transform.position.x + groundSize / 2 + gap / 2, player.transform.position.y - yOffsetGround, 0),
            Quaternion.identity);
        tempFuckingCollider.SetActive(false);
        tempGap.GetComponent<GapStop>().fuckingCollider = tempFuckingCollider;
        objectMovement.MovingObjects.Add(tempFuckingCollider);

    }
}

