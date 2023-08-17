namespace C_Sharp_Study {
    public class Pair<T, V> {
        public T First { get; set; }
        public V Second { get; set; }

        public Pair(T first, V second) {
            this.First = first;
            this.Second = second;
        }
    }
}