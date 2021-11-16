using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private Vector2 ParallaxEfekMultiple;
    [SerializeField] private bool infiniteHorizontal;
    [SerializeField] private bool infiniteVertical;

    private Transform cameraTransform;
    private Vector3 LastCamPosition;
    private float textureUnitSizeX;
    private float textureUnitSizeY;

    private void Start(){
        cameraTransform = Camera.main.transform;
        LastCamPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
        textureUnitSizeY = texture.height / sprite.pixelsPerUnit;
    }

    private void LateUpdate(){
        Vector3 deltaMove = cameraTransform.position - LastCamPosition;
        transform.position += new Vector3(deltaMove.x * ParallaxEfekMultiple.x , deltaMove.y * ParallaxEfekMultiple.y);
        LastCamPosition = cameraTransform.position;

        if(infiniteHorizontal){
            if(Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureUnitSizeX){
                float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureUnitSizeX;
                transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y);
            }
        }

        if(infiniteVertical){
            if(Mathf.Abs(cameraTransform.position.y - transform.position.y) >= textureUnitSizeY){
                float offsetPositionY = (cameraTransform.position.y - transform.position.y) % textureUnitSizeY;
                transform.position = new Vector3(transform.position.x, cameraTransform.position.y + offsetPositionY);
            }
        }
    }
}