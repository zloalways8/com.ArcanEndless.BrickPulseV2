using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class VBNlkaskldq : SAOsjklvntlrke
    {
        [SerializeField] private float loadingDuration = 1f;
        
        public void Load()
        {
            StartCoroutine(LoadingCoroutine());
        }

        private IEnumerator LoadingCoroutine()
        {
            var loadingProgress = 0f;
            
            while (loadingProgress < loadingDuration)
            {
                loadingProgress += Time.deltaTime;
                
                yield return null;
            }
            
            OPakolnsadq.StartBackgroundMelody();
            Wklnverlk.VBSNkdnwlkeryt4r<eKSANDlklre>();
        }
    }
}