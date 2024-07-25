using UnityEngine;
using System.Collections;

public class TideController : MonoBehaviour
{
    public GameObject[] targetObjects; // Danh s�ch c�c ??i t??ng c?n ?n hi?n
    public float hideTime = 2.0f; // Th?i gian ?n
    public float showTime = 2.0f; // Th?i gian hi?n

    private void Start()
    {
        StartCoroutine(HideAndShow());
    }

    private IEnumerator HideAndShow()
    {
        while (true)
        {
            // ?n t?t c? c�c ??i t??ng trong danh s�ch
            foreach (GameObject obj in targetObjects)
            {
                obj.SetActive(false);
            }
            yield return new WaitForSeconds(hideTime);

            // Hi?n t?t c? c�c ??i t??ng trong danh s�ch
            foreach (GameObject obj in targetObjects)
            {
                obj.SetActive(true);
            }
            yield return new WaitForSeconds(showTime);
        }
    }
}
