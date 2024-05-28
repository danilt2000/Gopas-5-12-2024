namespace CompositeDemo
{
    public class Directory : FileSystemItem
    {
        public Directory(string name) : base(name)
        {
        }

        public IList<FileSystemItem> Children { get; init; } = new List<FileSystemItem>();

        public override void Delete()
        {
            foreach (FileSystemItem item in Children) { item.Delete(); }
            base.Delete();
        }
    }
}
