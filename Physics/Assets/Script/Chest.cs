using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Chest : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] public List<Apple> apple;

    public void OnPointerClick(PointerEventData  eventData)
    {
        Instantiate(apple[0], transform.position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
