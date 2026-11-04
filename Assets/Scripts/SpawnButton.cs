
using UnityEngine;

public class SpawnButton : MonoBehaviour
{    public GameObject spawnme;
    public Vector3 spawnP = new Vector3(0, 0, 0);
    public void SpawnObject() {
        if (spawnme == null)
        {      Debug.LogWarning("*****No prefab in the script****");
            //check if theres an object attatched to the script
            return;    }
        GameObject spawnedOBJ = Instantiate(
            spawnme,
            spawnP,  Quaternion.identity
        );

        Debug.Log("Spawned object succesfuly");
    }
}
