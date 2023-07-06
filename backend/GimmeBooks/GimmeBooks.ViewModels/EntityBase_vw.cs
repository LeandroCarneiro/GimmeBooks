namespace GimmeBooks.ViewModels
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }

    public class EntityBase_vw<T>
    {
        public T Id { get; set; }
    }
}
