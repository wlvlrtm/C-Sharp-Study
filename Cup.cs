namespace C_Sharp_Study {
    public class Cup<T> where T : IKs {
        public T Type { get; set; }
    }

    public class Juice : IKs {
        
    }

    public class Coffee : IKs {
        
    }
}