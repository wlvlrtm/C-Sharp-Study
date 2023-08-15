using System;
using System.Collections;

namespace C_Sharp_Study {
    public class Car : IStandard {
        /// <summary>
        /// Car.cs
        /// </summary>

        #region Variable
        private string carName;
        private string[] carNames;
        private readonly int _len;
        #endregion

        #region Field
        public string CarName {
            get { return this.carName; }
            set { this.carName = value; }
        }
        public int Length {
            get { return this._len; }
        }
        #endregion

        #region Indexer
        public string this[int index] {
            get { return this.carNames[index]; }
            set { this.carNames[index] = value; }
        }
        #endregion

        #region Event
        public delegate void EventHandler();
        public event EventHandler Click;
        #endregion
        
        #region Constructor
        public Car() {
            this.carName = "My car";
        }

        public Car(string carName) {
            this.carName = carName;
        }

        public Car(int len) {
            this._len = len;
            this.carNames = new string[this._len];
        }
        #endregion

        #region Method
        public void Run() {
            Console.WriteLine("{0} is running.", this.carName);    
        }
        
        public void OnClick() {
            if (Click != null) {
                Click();
            }
        }
        #endregion

        #region Iterator
        public IEnumerator GetEnumerator() {
            for (int i = 0; i < this._len; i++) {
                yield return this.carNames[i];
            }
        }
        #endregion
    }
}