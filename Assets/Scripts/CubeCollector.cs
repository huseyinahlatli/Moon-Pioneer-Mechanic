using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeCollector : MonoBehaviour
{
    [SerializeField] Transform itemHolderTransform;
    private int numOfImtesHolding = 0;

    public void AddNewItem(Transform itemToAdd)
    {
        itemToAdd.DOMove(itemHolderTransform.position, 1.0f).OnComplete(()=>
        {
                itemToAdd.SetParent(itemHolderTransform, true);
                itemToAdd.localPosition = new Vector3(0.0275f * numOfImtesHolding, 0, 0);
                itemToAdd.localRotation = Quaternion.identity;
                numOfImtesHolding++;
        });
        
        /*   Jump Collect
         *   itemToAdd.DOJump(itemHolderTransform.position + new Vector3(0,0275f * numOfImtesHolding, 0 ), 1.5f, 1, 0.25f).OnComplete(()=>
         *   {
         *        itemToAdd.SetParent(itemHolderTransform, true);
         *        itemToAdd.localPosition = new Vector3(0.0275f * numOfImtesHolding, 0, 0);
         *        itemToAdd.localRotation = Quaternion.identity;
         *        numOfImtesHolding++;
         *   });
         */
    }
}
    