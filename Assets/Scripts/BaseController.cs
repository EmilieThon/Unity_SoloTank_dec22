using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{

    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected int LifePoint = 1;
    [SerializeField] protected float DelayValue = 2f;

    protected void Fire()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position*10, BulletSpawnPosition.transform.rotation);

    }

    // Update is called once per frame
    private void Update()
    {

        RaycastHit[] hits;
        if (Physics.Raycast(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up, out hits))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 20f, Color.red);
            Fire();
        } 
    }


}
