using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ChestSpawn : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] public List<Apple> apple;

    public void OnPointerClick(PointerEventData  eventData)
    {
        Instantiate(apple[0], transform.position, Quaternion.identity);
    }
}
