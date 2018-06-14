using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;

/// <summary>
/// Example of control application for drag and drop events handle
/// </summary>
public class DragAndDropController: MonoBehaviour
{
	[SerializeField]
	DragAndDropItem item;
	[SerializeField]
	bool DeleteOnDrop = false;
	/// <summary>
    /// Operate all drag and drop requests and events from children cells
    /// </summary>
    /// <param name="desc"> request or event descriptor </param>
    void OnSimpleDragAndDropEvent(DragAndDropCell.DropEventDescriptor desc)
    {
        
		// Get control unit of source cell
        DragAndDropController sourceSheet = desc.sourceCell.GetComponentInParent<DragAndDropController>();
        // Get control unit of destination cell
        DragAndDropController destinationSheet = desc.destinationCell.GetComponentInParent<DragAndDropController>();
        switch (desc.triggerType)                                               // What type event is?
        {
            case DragAndDropCell.TriggerType.DropRequest:                       // Request for item drag (note: do not destroy item on request)
                Debug.Log("Request " + desc.item.name + " from " + sourceSheet.name + " to " + destinationSheet.name);
                break;
            case DragAndDropCell.TriggerType.DropEventEnd:                      // Drop event completed (successful or not)
                if (desc.permission == true)                                    // If drop successful (was permitted before)
                {
                    Debug.Log("Successful drop " + desc.item.name + " from " + sourceSheet.name + " to " + destinationSheet.name);
						if (DeleteOnDrop == true) 
						{
						RemoveFirstItem ();
						}
                }
                else                                                            // If drop unsuccessful (was denied before)
                {
                    Debug.Log("Denied drop " + desc.item.name + " from " + sourceSheet.name + " to " + destinationSheet.name);
                }
                break;
            case DragAndDropCell.TriggerType.ItemAdded:                         // New item is added from application
                Debug.Log("Item " + desc.item.name + " added into " + destinationSheet.name);
                break;
            case DragAndDropCell.TriggerType.ItemWillBeDestroyed:               // Called before item be destructed (can not be canceled)
                Debug.Log("Item " + desc.item.name + " will be destroyed from " + sourceSheet.name);
                break;
            default:
                Debug.Log("Unknown drag and drop event");
                break;
        }
    }

    /// <summary>
    /// Add item in first free cell
    /// </summary>
    /// <param name="item"> new item </param>
	public void AddItemInFreeCell(DragAndDropItem item)
    {
        foreach (DragAndDropCell cell in GetComponentsInChildren<DragAndDropCell>())
        {
            if (cell != null)
            {
				if (cell.GetItem() == null)
                {
					cell.AddItem(Instantiate(item.gameObject).GetComponent<DragAndDropItem>());

					break;
                }
            }
        }
    }

	public void AddForIndex1()
	{
		AddItemInFreeCell (item);
	}

	public void AddForIndex2()
	{
		AddItemInFreeCell (item);
	}

	public void AddForIndex3()
	{
		AddItemInFreeCell (item);
	}

	public void AddForIndex4()
	{
		AddItemInFreeCell (item);
	}


		
    /// <summary>
    /// Remove item from first not empty cell
    /// </summary>
    public void RemoveFirstItem()
    {
        foreach (DragAndDropCell cell in GetComponentsInChildren<DragAndDropCell>())
        {
            if (cell != null)
            {
				if (cell.GetItem() != null)
                {
                    cell.RemoveItem();
                    break;
                }
            }
        }
    }
}


