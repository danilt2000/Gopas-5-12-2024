namespace GenericsDemo
{
    public class Generic<T> where T : IDoable
    {
        private T doable;

        public Generic(T doable)
        {
            this.doable = doable;
        }

        public void UseDoable() {
            doable.Do();
        }
    }
}
