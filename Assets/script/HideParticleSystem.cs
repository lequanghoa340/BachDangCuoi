using System.Collections;
using UnityEngine;

public class HideParticleSystem : MonoBehaviour
{
    public ParticleSystem particleSystem; // Gán Particle System trong Unity Editor
    public float duration = 10f; // Th?i gian gi?m s? h?t t?i ?a

    void Start()
    {
        // G?i hàm HideAfterDelay sau 18 giây
        Invoke("HideAfterDelay", 35f);
        // B?t ??u gi?m s? h?t d?n d?n
        StartCoroutine(ReduceMaxParticles());
    }

    void HideAfterDelay()
    {
        // ?n Particle System
        particleSystem.Stop();
        particleSystem.gameObject.SetActive(false);
    }

    IEnumerator ReduceMaxParticles()
    {
        ParticleSystem.MainModule mainModule = particleSystem.main;
        int initialMaxParticles = mainModule.maxParticles;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            mainModule.maxParticles = (int)Mathf.Lerp(initialMaxParticles, 0, t);
            yield return null;
        }

        mainModule.maxParticles = 0; // ??m b?o s? h?t là 0 sau khi k?t thúc
    }
}
