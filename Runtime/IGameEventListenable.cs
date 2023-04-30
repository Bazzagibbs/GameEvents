namespace BazzaGibbs.GameEvents {
    public interface IGameEventListenable {
        public void Invoke();
    }

    public interface IGameEventListenable<in T> {
        public void Invoke(T val);
    }
}