using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomItem : MonoBehaviour
{
    public List<Sprite> itens;
    public Image imageItem;

    public bool RandomItens()
    {
        if (imageItem != null)
        {
            imageItem.sprite = itens[Random.Range(0, itens.Count)];
            imageItem.SetNativeSize();
            return true;
        }
        else return false;
    }

    public bool RandomList()
    {
        int index = itens.Count;
        if (index == 0) return false;
        else
        {
            List<Sprite> sprites = new List<Sprite>();
            for (int i = 0; i < index; i++)
            {
                Sprite item = itens[Random.Range(0, itens.Count)];
                itens.Remove(item);
                sprites.Add(item);
            }
            itens = new List<Sprite>();
            foreach (Sprite sprite in sprites)
            {
                itens.Add(sprite);
            }
            return true;
        }
    }
}