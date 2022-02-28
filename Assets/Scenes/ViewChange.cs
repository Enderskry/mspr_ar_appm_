using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes
{
    public class ViewChange : MonoBehaviour
    {
        public void BlankARView() {  
            SceneManager.LoadScene("BlankAR");
        }
        public void MenuView() {  
            SceneManager.LoadScene("Menu");
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
}
