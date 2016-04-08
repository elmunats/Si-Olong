using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandeler : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler  {



	public  static GameObject itemBeingDragged;
	public static string  tagdipilih;
	Vector2 startPosition;
	Transform startParent;


	 public  void Start()
	{
		 
	}
	public void update()
	{


	}


	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}


	#endregion


	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
		tagdipilih = transform.tag;

	}

	#endregion


	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;


	
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if (transform.parent == startParent) {
			transform.position = startPosition;

		}



	

		}


	#endregion





}
