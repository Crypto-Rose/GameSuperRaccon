using UnityEngine;
using UnityEngine.SceneManagement;
public class MuerteSuper : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 5)
            SceneManager.LoadScene(0);

        if(transform.position.y < -5)
            SceneManager.LoadScene(0);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
