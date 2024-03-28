using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
  [SerializeField] private Camera playerCamera;
  [SerializeField] private float interactionDistance = 5.0f;
  [SerializeField] private LayerMask interactionLayer;


  private void Update(){
    RaycastHit hit; 
    Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

    if(Physics.Raycast(ray, out hit, interactionDistance, interactionLayer))
    {

        switch(hit.collider.tag)
        {
            case "Interaction/Door":
                InteractionDoor(hit);
                break;
        }

    }
  }

  private void InteractionDoor(RaycastHit hit)
  {
    Debug.Log($"je regarde {hit.collider.name}");
  }

}
