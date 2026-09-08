using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact()
    {
        Debug.Log("Interract!");
        Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prehab, counterTopPoint);
        KitchenObjectTransform.localPosition = Vector3.zero;
    }
}
