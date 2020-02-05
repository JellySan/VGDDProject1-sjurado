using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    #region chest_variables
    [SerializeField]
    [Tooltip("HealthPack")]
    private GameObject healthPack;
    #endregion

    #region chest_functions
    IEnumerator DeleteChest()
    {
        yield return new WaitForSeconds(0.3f);

        Instantiate(healthPack, transform.position, transform.rotation);

        Destroy(this.gameObject);
    }

    public void Interact()
    {
        StartCoroutine(DeleteChest());
    }
    #endregion
}
