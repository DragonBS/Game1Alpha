using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseTank : MonoBehaviour
{
    public Button tankMenuOpenButton;
    public Image selectedTankImage;

    public void SpriteChange()
    {
        tankMenuOpenButton.image.sprite = selectedTankImage.sprite;
    }
}
