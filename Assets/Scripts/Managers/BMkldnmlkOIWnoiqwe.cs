using Content;
using Entities;
using UnityEngine;

namespace Managers
{
    public class BMkldnmlkOIWnoiqwe
    {
        private const string IUOwhofvreno3 = "BNjkfenkjasqe";
        private const string BNkrkljejnkWJK = "BNjdksqqw";
        private const string Qwerpzcv34 = "BVBjkfkejkw";
        private const string WIOLvhoer = "terve";
        private const string WIOvnjotirw = "BVjkjkskjq";
        private const string Bahjjwqrt = "QOPjgproept";
        
        private readonly BNjkrengjk2 _bNjkrengjk2;

        public int POJQWPoif => PlayerPrefs.GetInt(IUOwhofvreno3);
        public int Gqwrgt4r => _bNjkrengjk2.BVNjkrenkj2.Length;

        public bool QcEwer1
        {
            get => PlayerPrefs.GetInt(BNkrkljejnkWJK) == 1;
            set => PlayerPrefs.SetInt(BNkrkljejnkWJK, value ? 1 : 0);
        }

        public bool Wopjvporte
        {
            get => PlayerPrefs.GetInt(Qwerpzcv34) == 1;
            set => PlayerPrefs.SetInt(Qwerpzcv34, value ? 1 : 0);
        }

        public bool OLPPPotr4
        {
            get => PlayerPrefs.GetInt(WIOLvhoer) == 1;
            set => PlayerPrefs.SetInt(WIOLvhoer, value ? 1 : 0);
        }

        public int ASKnmlvlrt
        {
            get => PlayerPrefs.GetInt(WIOvnjotirw);
            set => PlayerPrefs.SetInt(WIOvnjotirw, value);
        }

        public int WNvnjreklqw
        {
            get => PlayerPrefs.GetInt(Bahjjwqrt);
            set => PlayerPrefs.SetInt(Bahjjwqrt, value);
        }
            
        
        public BMkldnmlkOIWnoiqwe(BNjkrengjk2 bNjkrengjk2)
        {
            _bNjkrengjk2 = bNjkrengjk2;

            if (!PlayerPrefs.HasKey(IUOwhofvreno3))
            {
                PlayerPrefs.SetInt(IUOwhofvreno3, 0);
            }

            if (!PlayerPrefs.HasKey(BNkrkljejnkWJK))
            {
                PlayerPrefs.SetInt(BNkrkljejnkWJK, 0);
            }
            
            if (!PlayerPrefs.HasKey(Qwerpzcv34))
            {
                PlayerPrefs.SetInt(Qwerpzcv34, 0);
            }

            if (!PlayerPrefs.HasKey(WIOLvhoer))
            {
                PlayerPrefs.SetInt(WIOLvhoer, 0);
            }

            if (!PlayerPrefs.HasKey(WIOvnjotirw))
            {
                PlayerPrefs.SetInt(WIOvnjotirw, 0);
            }

            if (!PlayerPrefs.HasKey(Bahjjwqrt))
            {
                PlayerPrefs.SetInt(Bahjjwqrt, 0);
            }
        }

        public BNjksbnrgfjkw3eASF GetLevelData(int index) =>
            _bNjkrengjk2.BVNjkrenkj2[index];

        public void IncreasePassedLevels(int currentLevel)
        {
            if (currentLevel == POJQWPoif)
                PlayerPrefs.SetInt(IUOwhofvreno3, POJQWPoif + 1);
        }
    }
}